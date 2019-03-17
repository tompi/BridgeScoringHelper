using System;
using Xamarin.Forms;

namespace BridgeScoringHelper.Components.Suit
{
    public class DiamondButton : ButtonLayout
    {
        public DiamondButton()
        {
            Content = new Diamond
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };
            BackgroundColor = BridgeScoringHelper.Style.Colors.Suits.DiamondBackground;

        }
    }
}
