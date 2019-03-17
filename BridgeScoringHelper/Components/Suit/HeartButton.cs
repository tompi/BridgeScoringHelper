using BridgeScoringHelper.Style;

namespace BridgeScoringHelper.Components.Suit
{
    public class HeartButton : LabelButton
    {
        public HeartButton()
        {
            _label.Text = Constants.Suit.HeartUnicodeCharacter.ToString();
            _label.TextColor = Colors.Suits.Heart;
            BackgroundColor = Colors.Suits.HeartBackground;
        }
    }
}
