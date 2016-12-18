using System;
using System.Windows.Forms;
using OesUI.utils;

namespace OesUI.Custom
{
    public partial class CustomTipDialog : UserControl
    {
        private const string CONFIRM = "confirm";

        public CustomTipDialog()
        {
            InitializeComponent();
            ChangeLanguage();
        }

        public void ChangeLanguage()
        {
            this.lblConfirm.Text = ResourceCulture.GetString(CONFIRM);
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (this.Tag as MyOpaqueLayer).Hide();
        }

        private void LblConfirm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (this.Tag as MyOpaqueLayer).Hide();
        }
    }
}
