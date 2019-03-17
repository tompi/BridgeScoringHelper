﻿using System;
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
                TextColor = Color.Black
            };
            _innerFrame = new Frame
            {
                HasShadow = false,
                Content = _label,
                Padding = 0,
                Margin=5,
                CornerRadius = 5
            };
            Content = _innerFrame;
            CornerRadius = 5;
            Padding = 0;
            Margin = 0;
        }
    }
}
