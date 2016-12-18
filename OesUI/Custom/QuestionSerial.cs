using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace OesUI.Custom
{
    public class QuestionSerial : Control
    {
        private int borderRadius = 3;
        private int defaultWidth = 30;
        private int defaultHeight = 25;
        public Color BorderColor { get; set; }
        public Color FontColor { get; set; }
        private Color defaultBorderColor = Color.FromArgb(254, 153, 1);
        private Color defaultFontColor = Color.FromArgb(10, 10, 10);

        public QuestionSerial()
        {
            this.Width = defaultWidth;
            this.Height = defaultHeight;
            this.BorderColor = defaultBorderColor;
            this.FontColor = defaultFontColor;
        }

        private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int cornerRadius)
        {
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius * 2, rect.Y);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Y + rect.Height - cornerRadius * 2);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2,
                cornerRadius * 2, 0, 90);
            roundedRect.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
            roundedRect.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.AddLine(rect.X, rect.Bottom - cornerRadius * 2, rect.X, rect.Y + cornerRadius * 2);
            roundedRect.CloseFigure();
            return roundedRect;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = CreateRoundedRectanglePath(new Rectangle(0, 0, this.Width - 1, this.Height - 1), borderRadius))
            {
                e.Graphics.DrawPath(new Pen(this.BorderColor), path);
            }

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.FontColor), 
                new Rectangle(0, 0, this.Width, this.Height), sf);
        }
    }
}
