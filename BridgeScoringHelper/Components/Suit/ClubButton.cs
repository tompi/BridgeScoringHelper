using BridgeScoringHelper.Style;

namespace BridgeScoringHelper.Components.Suit
{
    public class ClubButton : LabelButton
    {
        public ClubButton()
        {
            _label.Text = Constants.Suit.ClubUnicodeCharacter.ToString();
            _label.TextColor = Colors.Suits.Club;
            BackgroundColor = Colors.Suits.ClubBackground;

        }
    }
}
