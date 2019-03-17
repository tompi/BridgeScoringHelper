using System;
using Xamarin.Forms;

namespace BridgeScoringHelper.Components
{
    public class LabelButton : ButtonLayout
    {
        private Label _label;
        public string Text
        {
            get => _label.Text;
            set => _label.Text = value;
        }

        public Color TextColor
        {
            get => _label.TextColor;
            set => _label.TextColor = value;
        }

        public LabelButton()
        {
            _label = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black
            };
            Content = _label;
            BackgroundColor = Color.White;
        }
    }
}
