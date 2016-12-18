using System.Drawing;
using System.Windows.Forms;

namespace OesUI.Custom
{
    public class CustomTimePicker : DateTimePicker
    {
        private const int WM_ERASEBKGND = 0x14;

        private Color backColor = Color.White;

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == WM_ERASEBKGND)
            {
                Graphics g = Graphics.FromHdc(m.WParam);

                //draw bgColor
                g.FillRectangle(new SolidBrush(backColor), ClientRectangle);
                g.Dispose();
                return;
            }

            base.WndProc(ref m);
        }
    }
}
