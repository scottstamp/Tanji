using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Tanji.Components
{
    public class TanjiModePanel : Control
    {
        private readonly Color[] _glowColors;

        private int _modeWidth;
        private Rectangle _automaticRegion, _manualRegion;
        private Color _automaticGlowColor, _manualGlowColor;

        public event EventHandler ModeChanged;
        protected virtual void OnModeChanged(EventArgs e)
        {
            EventHandler handler = ModeChanged;
            if (handler != null) ModeChanged(this, e);
        }

        private bool _isManual = false;
        [DefaultValue(false)]
        public bool IsManual
        {
            get { return _isManual; }
            set
            {
                if (!Enabled || _isManual == value) return;

                _isManual = value;
                _manualGlowColor = _glowColors[_isManual ? 1 : 0];
                _automaticGlowColor = _glowColors[_isManual ? 0 : 1];

                Invalidate();
                OnModeChanged(EventArgs.Empty);
            }
        }

        public TanjiModePanel()
        {
            SetStyle((ControlStyles)2050, true);
            DoubleBuffered = true;

            _glowColors = new[] { Color.Silver, Color.FromArgb(243, 63, 63) };

            _automaticGlowColor = _glowColors[1];
            _manualGlowColor = _glowColors[0];

            Size = new Size(330, 33);
            Font = new Font("Segoe UI", 15);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            using (var automaticGlow = new SolidBrush(_automaticGlowColor))
                e.Graphics.FillRectangle(automaticGlow, _automaticRegion.X, Height - 2, _modeWidth, 2);

            using (var manualGlow = new SolidBrush(_manualGlowColor))
                e.Graphics.FillRectangle(manualGlow, _manualRegion.X, Height - 2, _modeWidth, 2);

            using (var stringFormat = new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center })
            {
                e.Graphics.DrawString("Manual", Font, Brushes.Black, _manualRegion, stringFormat);
                e.Graphics.DrawString("Automatic", Font, Brushes.Black, _automaticRegion, stringFormat);
            }

            base.OnPaint(e);
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            _modeWidth = (Width / 2) - 15;

            _automaticRegion = new Rectangle(12, 0, _modeWidth, Height);
            _manualRegion = new Rectangle(_modeWidth + 18, 0, _modeWidth, Height);

            base.OnSizeChanged(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            bool clickedAutomatic = _automaticRegion.Contains(e.Location);
            bool clickedManual = _manualRegion.Contains(e.Location);
            if (!clickedAutomatic && !clickedManual) return;

            base.OnMouseDown(e);
            IsManual = clickedManual;
        }
    }
}