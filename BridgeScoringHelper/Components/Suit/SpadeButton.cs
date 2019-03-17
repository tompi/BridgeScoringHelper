using System;
using Xamarin.Forms;

namespace BridgeScoringHelper.Components.Suit
{
    public class SpadeButton : ButtonLayout
    {
        public SpadeButton()
        {
            Content = new Spade
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };
            BackgroundColor = BridgeScoringHelper.Style.Colors.Suits.SpadeBackground;

        }
    }
}
