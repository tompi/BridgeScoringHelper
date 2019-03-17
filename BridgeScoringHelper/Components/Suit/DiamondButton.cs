using BridgeScoringHelper.Style;

namespace BridgeScoringHelper.Components.Suit
{
    public class DiamondButton : LabelButton
    {
        public DiamondButton()
        {
            _label.Text = Constants.Suit.DiamondUnicodeCharacter.ToString();
            _label.TextColor = Colors.Suits.Diamond;
            BackgroundColor = Colors.Suits.DiamondBackground;
        }
    }
}
