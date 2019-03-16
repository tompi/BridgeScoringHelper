using System;
using BridgeScoringHelper.Style;

namespace BridgeScoringHelper.Components.Suit
{
    public class Heart : SuitBase
    {
        public Heart()
        {
            Text = '\u2665'.ToString();
            TextColor = Colors.Suits.Heart;
        }
    }
}
