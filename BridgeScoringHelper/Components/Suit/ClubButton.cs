using System;
using Xamarin.Forms;

namespace BridgeScoringHelper.Components.Suit
{
    public class ClubButton : ButtonLayout
    {
        public ClubButton()
        {
            Content = new Club
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };
            BackgroundColor = BridgeScoringHelper.Style.Colors.Suits.ClubBackground;

        }
    }
}
