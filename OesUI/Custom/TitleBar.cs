using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OesUI.Custom
{
    public partial class TitleBar : UserControl
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int VM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public TitleBar()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent).Close();
        }

        private void LblMax_Click(object sender, EventArgs e)
        {
            FormMaxOrMin();
        }

        private void LblMin_Click(object sender, EventArgs e)
        {
            Form parentForm = ((Form)this.Parent);
            if (parentForm.WindowState == FormWindowState.Minimized)
            {
                parentForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                parentForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void LblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(((Form)this.Parent).Handle, VM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void FormMaxOrMin()
        {
            Form parentForm = ((Form)this.Parent);
            if (parentForm.WindowState == FormWindowState.Maximized)
            {
                parentForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                parentForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void lblTitle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormMaxOrMin();
        }
    }
}
