using System;
using System.Collections.Generic;
using BridgeScoringHelper.Components;
using Scoring.Game;
using Xamarin.Forms;

namespace BridgeScoringHelper.Calculator
{
    public partial class Calculator : BaseContentPage
    {
        private int _tricks;
        public Calculator()
        {
            InitializeComponent();

            // Initialize contract to 2S=
            contractEntry.Contract = new Contract(2, Suit.Spades, false, false, Direction.South, _tricks);
            ContractEntry_ContractChanged(this, null);
            _tricks = contractEntry.Contract.Level + 6;
            tricksLabel.Text = _tricks.ToString();

            // Respond to clicks and events
            minusButton.Clicked += MinusButton_Clicked;
            plusButton.Clicked += PlusButton_Clicked;
            contractEntry.ContractChanged += ContractEntry_ContractChanged;
        }

        void MinusButton_Clicked(object sender, EventArgs e)
        {
            _tricks--;
            if (_tricks < 0) _tricks = 0;
            tricksLabel.Text = _tricks.ToString();
            ContractEntry_ContractChanged(sender, e);
        }

        void PlusButton_Clicked(object sender, EventArgs e)
        {
            _tricks++;
            if (_tricks > 13) _tricks = 13;
            tricksLabel.Text = _tricks.ToString();
            ContractEntry_ContractChanged(sender, e);
        }

        void ContractEntry_ContractChanged(object sender, EventArgs e)
        {
            // Get contract, vulnerability and tricks
            var contract = contractEntry.Contract;
            contract.Tricks = _tricks;
            var isVulnerable = contractEntry.Vulnerability.IsVulnerable(Direction.South);

            // Calculate score
            var score = Scoring.Score.Calculator.GetNorthSouthPoints(contract, isVulnerable);

            // Present result
            result.Text = CalculatorMapper.GetContractAndResultString(contract, isVulnerable, score);
        }
    }
}
