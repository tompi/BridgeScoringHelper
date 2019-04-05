using System;
using Xamarin.Forms;

namespace BridgeScoringHelper.Components
{
    public class LabelButton : ButtonLayout
    {
        internal Label _label;
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

        private bool _selected;
        public bool Selected
        {
            get => _selected;
            set
            {
                _selected = value;
                base.BackgroundColor = _selected ? Color.Yellow : _innerFrame.BackgroundColor;
            }
        }

        private LineBreakMode _lineBreakMode;
        public LineBreakMode LineBreakMode
        {
            get => _lineBreakMode;
            set
            {
                _lineBreakMode = value;
                _label.LineBreakMode = _lineBreakMode;
            }
        }

        public new Color BackgroundColor
        {
            get => _innerFrame.BackgroundColor;
            set
            {
                base.BackgroundColor = value;
                _innerFrame.BackgroundColor = value;
            }
        }

        private Frame _innerFrame;

        public LabelButton()
        {
            _label = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black,
                FontSize = App.SizeManager.FontSize,
                FontAttributes = FontAttributes.Bold,
            };
            _innerFrame = new Frame
            {
                HasShadow = false,
                Content = _label,
                Padding = new Thickness(0, App.SizeManager.ButtonVerticalPadding),
                Margin=5,
                CornerRadius = App.SizeManager.CornerRadius * 3f / 5f
            };
            Content = _innerFrame;
            CornerRadius = App.SizeManager.CornerRadius;
            Padding = 2;
            Margin = 0;
        }
    }
}
