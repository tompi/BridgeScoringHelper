using System;
using Xamarin.Forms;

namespace BridgeScoringHelper.Components
{
    public class ButtonLayout : Frame
    {
        public event EventHandler Clicked;
        public ButtonLayout()
        {
            CornerRadius = 3;
            GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(() => Clicked?.Invoke(this, null)) });
            HasShadow = false;
        }
    }
}
