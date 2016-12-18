using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OesUI.utils;

namespace OesUI.Custom
{
    public partial class TipForm : Form
    {
        private const string FORGET_PASSWORD = "forgetPasswordMessage";
        private const string CONFIRM = "confirm";
        private const string CANCEL = "Cancel";
        private const string TIME_OUT = "TimeOut";
        
        public TipForm()
        {
            InitializeComponent();

            this.lblMessage.Text = ResourceCulture.GetString(FORGET_PASSWORD);
            this.lblConfirm.Text = ResourceCulture.GetString(CONFIRM);
            this.lblCancel.Text = ResourceCulture.GetString(CANCEL);
        }

        public void SetIsShowCancel(bool isShowCancel)
        {
            if (!isShowCancel)
            {
                this.lblCancel.Hide();
            }
            else
            {
                this.lblCancel.Show();
            }
        }

        public void SetMessage(string message)
        {
            if (message.Equals(string.Empty))
            {
                this.lblMessage.Text = ResourceCulture.GetString(FORGET_PASSWORD);
            }
            else
            {
                this.lblMessage.Text = message;
            }
        }

        public void IsOpenTimer(bool isOpenTimer)
        {
            if (isOpenTimer)
            {
                this.customTimer.DoSomething = DoSomething;
                this.customTimer.GetTimer().Enabled = true;
                this.customTimer.GetTimer().Start();
            }
        }

        public CustomTimer GetCustomTimer()
        {
            return this.customTimer;
        }

        public void DoSomething()
        {
            this.lblMessage.Text = ResourceCulture.GetString(TIME_OUT);

            this.lblConfirm.Click -= new System.EventHandler(this.lblConfirm_Click);
            this.lblConfirm.Click += new System.EventHandler(this.lblConfirm_Clk);
        }

        private void lblConfirm_Clk(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        private void lblConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
