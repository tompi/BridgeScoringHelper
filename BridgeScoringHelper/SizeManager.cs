using System;
namespace BridgeScoringHelper
{
    public class SizeManager
    {
        // Inspired by: https://stackoverflow.com/questions/38891654/get-current-screen-width-in-xamarin-forms
        public int ScreenHeight { get; }
        public int ScreenWidth { get; }

        public double FontSize { get; }
        public float CornerRadius { get; }
        public double ButtonVerticalPadding { get; }


        public SizeManager(int screenHeight, int screenWidth)
        {
            ScreenHeight = screenHeight;
            ScreenWidth = screenWidth;

            FontSize = ScreenHeight / 40d;
            CornerRadius = ScreenHeight / 180f;
            ButtonVerticalPadding = ScreenHeight / 69d;

        }
    }
}
