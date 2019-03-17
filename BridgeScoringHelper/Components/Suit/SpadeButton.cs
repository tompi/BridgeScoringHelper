using System;
using BridgeScoringHelper.Style;
using Xamarin.Forms;

namespace BridgeScoringHelper.Components.Suit
{
    public class SpadeButton : LabelButton
    {
        public SpadeButton()
        {
            _label.Text = Constants.Suit.SpadeUnicodeCharacter.ToString();
            _label.TextColor = Colors.Suits.Spade;
            BackgroundColor = Colors.Suits.SpadeBackground;

        }
    }
}
