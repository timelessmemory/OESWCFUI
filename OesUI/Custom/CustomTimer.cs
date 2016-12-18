using System.Windows.Forms;

namespace OesUI.Custom
{
    public delegate void DoSomethingDelegate();

    public partial class CustomTimer : UserControl
    {
        public DoSomethingDelegate DoSomething;

        private int count = 30;

        public CustomTimer()
        {
            InitializeComponent();
        }

        public Timer GetTimer()
        {
            return this.VerificationTimer;
        }

        public void SetCount(int count)
        {
            this.count = count;
        }

        public int GetCount()
        {
            return this.count;
        }

        private void VerificationTimer_Tick(object sender, System.EventArgs e)
        {
            int rs = count--;

            this.lblShowTime.Text = rs.ToString();

            if (rs == 0 && DoSomething != null)
            {
                this.VerificationTimer.Enabled = false;
                FormPassValue.isSendEmail = false;
                DoSomething();
            }
        }
    }
}
