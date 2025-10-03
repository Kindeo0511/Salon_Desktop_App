using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Util
{
    public class ReceiptRenderer
    {
        private readonly Graphics _g;
        private readonly Font _font;
        private readonly Font _boldFont;
        private readonly float _centerX;
        private float _y;

        private readonly float _labelX;
        private readonly float _valueX;
        private readonly float _valueWidth;
        private readonly StringFormat _rightAlign;

        public ReceiptRenderer(Graphics g, Font font, Font boldFont, float centerX)
        {
            _g = g;
            _font = font;
            _boldFont = boldFont;
            _centerX = centerX;
            _y = 10;

            float blockWidth = 280;
            float startX = centerX - (blockWidth / 2);
            _labelX = startX;
            _valueX = startX + 180;
            _valueWidth = 100;
            _rightAlign = new StringFormat { Alignment = StringAlignment.Far };
        }

        public void DrawHeader(string title)
        {
            SizeF size = _g.MeasureString(title, _boldFont);
            _g.DrawString(title, _boldFont, Brushes.Black, _centerX - (size.Width / 2), _y);
            _y += size.Height + 5;
        }

        public void DrawCenteredLines(string[] lines)
        {
            foreach (var line in lines)
            {
                SizeF size = _g.MeasureString(line, _font);
                _g.DrawString(line, _font, Brushes.Black, _centerX - (size.Width / 2), _y);
                _y += size.Height + 2;
            }
        }

        public void DrawSeparator()
        {
            _y += 5;
            _g.DrawLine(Pens.Gray, _labelX, _y, _valueX + _valueWidth, _y);
            _y += 5;
        }

        public void DrawLabelValue(string label, string value)
        {
            _g.DrawString(label, _font, Brushes.Black, _labelX, _y);
            RectangleF rect = new RectangleF(_valueX, _y, _valueWidth, _font.GetHeight(_g));
            _g.DrawString(value, _font, Brushes.Black, rect, _rightAlign);
            _y += _font.GetHeight(_g) + 2;
        }

        public void DrawBoldValue(string label, string value)
        {
            _g.DrawString(label, _boldFont, Brushes.Black, _labelX, _y);
            RectangleF rect = new RectangleF(_valueX, _y, _valueWidth, _boldFont.GetHeight(_g));
            _g.DrawString(value, _boldFont, Brushes.Black, rect, _rightAlign);
            _y += _boldFont.GetHeight(_g) + 5;
        }

        public void DrawFooter(string message)
        {
            _y += 10;
            SizeF size = _g.MeasureString(message, _font);
            _g.DrawString(message, _font, Brushes.Black, _centerX - (size.Width / 2), _y);
        }

        public float CurrentY => _y;
    }
}
