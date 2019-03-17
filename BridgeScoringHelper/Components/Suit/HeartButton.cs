using System;
using Xamarin.Forms;

namespace BridgeScoringHelper.Components.Suit
{
    public class HeartButton : ButtonLayout
    {
        public HeartButton()
        {
            Content = new Heart
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };
            BackgroundColor = BridgeScoringHelper.Style.Colors.Suits.HeartBackground;

        }
    }
}
