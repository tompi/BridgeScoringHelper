using System;
using System.Collections.Generic;
using Scoring.Game;
using Xamarin.Forms;

namespace BridgeScoringHelper
{
    public partial class Calculator : ContentPage
    {
        private int _tricks = 8;
        public Calculator()
        {
            InitializeComponent();

            // Initialize contract to 2S=
            contractEntry.Contract = new Scoring.Game.Contract(2, Scoring.Game.Suit.Spades, false, false, Scoring.Game.Direction.South, _tricks);

            // Respond to clicks and events
            minusButton.Clicked += MinusButton_Clicked;
            plusButton.Clicked += PlusButton_Clicked;

            contractEntry.ContractChanged += ContractEntry_ContractChanged;
        }

        void MinusButton_Clicked(object sender, EventArgs e)
        {
            _tricks--;
        }

        void PlusButton_Clicked(object sender, EventArgs e)
        {
            _tricks++;
        }

        void ContractEntry_ContractChanged(object sender, EventArgs e)
        {
            var contract = contractEntry.Contract;
            contract.Tricks = _tricks;
            var score = Scoring.Score.Calculator.GetNorthSouthPoints(contract, contractEntry.Vulnerability.IsVulnerable(Direction.South));
            Console.WriteLine("Score: " + score);
        }

    }
}
