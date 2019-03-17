using System;
using System.Collections.Generic;
using System.Linq;
using Scoring.Game;
using Scoring.Score;
using Xamarin.Forms;

namespace BridgeScoringHelper.Components
{
    public partial class ContractEntry : ContentView
    {
        public event EventHandler ContractChanged;

        private Dictionary<Scoring.Game.Suit, LabelButton> _suitButtons;
        private Dictionary<int, LabelButton> _levelButtons;

        public Contract Contract
        {
            get
            {
                var contract = new Contract();
                contract.Level = _levelButtons.FirstOrDefault(lb => lb.Value.Selected).Key;
                if (contract.Level != 0)
                {
                    contract.Suit = _suitButtons.FirstOrDefault(sb => sb.Value.Selected).Key;
                    contract.Doubled = doubledButton.Selected || redoubledButton.Selected;
                    contract.ReDoubled = redoubledButton.Selected;
                }
                return contract;
            }
            set
            {
                ToggleLevel(value.Level);
                ToggleSuit(value.Suit);
            }
        }

        public Vulnerability Vulnerability
        {
            get => vulnerabilityButton.Selected ? Vulnerability.Both : Vulnerability.None;
            set
            {
                vulnerabilityButton.Selected = value.IsVulnerable(Direction.South);
            }
        }

        private void ToggleLevel(int level)
        {
            foreach (var kvp in _levelButtons)
            {
                kvp.Value.Selected = kvp.Key == level;
            }
        }
        private void ToggleSuit(Scoring.Game.Suit suit)
        {
            foreach (var kvp in _suitButtons)
            {
                kvp.Value.Selected = kvp.Key == suit;
            }
        }

        public ContractEntry()
        {
            InitializeComponent();

            _suitButtons = new Dictionary<Scoring.Game.Suit, LabelButton>
            {
                {Scoring.Game.Suit.Clubs, clubButton},
                {Scoring.Game.Suit.Diamonds, diamondButton},
                {Scoring.Game.Suit.Hearts, heartButton},
                {Scoring.Game.Suit.Spades, spadeButton},
                {Scoring.Game.Suit.Notrump, noTrumpButton}
            };
            foreach (var kvp in _suitButtons) kvp.Value.Clicked += (sender, e) =>
            {
                ToggleSuit(kvp.Key);
                ContractChanged?.Invoke(sender, e);
            };

            _levelButtons = new Dictionary<int, LabelButton>
            {
                {0, passButton},
                {1, level1Button},
                {2, level2Button},
                {3, level3Button},
                {4, level4Button},
                {5, level5Button},
                {6, level6Button},
                {7, level7Button},
            };
            foreach (var kvp in _levelButtons) kvp.Value.Clicked += (sender, e) =>
            {
                ToggleLevel(kvp.Key);
                ContractChanged?.Invoke(sender, e);
            };

            passButton.BackgroundColor = BridgeScoringHelper.Style.Colors.Bidding.Pass;
            passButton.TextColor = Color.White;

            vulnerabilityButton.BackgroundColor = BridgeScoringHelper.Style.Colors.Bidding.Pass;
            vulnerabilityButton.TextColor = Color.White;
            vulnerabilityButton.Clicked += (sender, e) =>
            {
                ToggleButtonClicked(vulnerabilityButton, e);
                ContractChanged?.Invoke(sender, e);
            };

            doubledButton.BackgroundColor = BridgeScoringHelper.Style.Colors.Bidding.Doubled;
            doubledButton.TextColor = Color.White;
            doubledButton.Clicked += (sender, e) =>
            {
                ToggleButtonClicked(doubledButton, e);
                if (!doubledButton.Selected)
                {
                    // If not doubled, it cant be redoubled
                    redoubledButton.Selected = false;
                }
                ContractChanged?.Invoke(sender, e);
            };

            redoubledButton.BackgroundColor = BridgeScoringHelper.Style.Colors.Bidding.ReDoubled;
            redoubledButton.TextColor = Color.White;
            redoubledButton.Clicked += (sender, e) =>
            {
                ToggleButtonClicked(redoubledButton, e);
                if (redoubledButton.Selected)
                {
                    // If redoubled, it has to be doubled...
                    doubledButton.Selected = true;
                }
                ContractChanged?.Invoke(sender, e);
            };
        }

        void ToggleButtonClicked(object sender, EventArgs e)
        {
            var labelButton = sender as LabelButton;
            labelButton.Selected = !labelButton.Selected;
        }

    }
}
