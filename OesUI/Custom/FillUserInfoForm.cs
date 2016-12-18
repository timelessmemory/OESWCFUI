using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OesUI.utils;
using System.Runtime.InteropServices;

namespace OesUI.Custom
{
    public partial class FillUserInfoForm : Form
    {
        private const string USERNAME = "userName";
        private const string EMAIl = "Emails";
        private const string USER_NAME_REQ = "userNameRequired";
        private const string EMAIL_REQ = "EmailRequired";
        private const string USERNAME_AND_PASSWORD = "UserNameAndEmail";
        private const string FIND_PASSORD = "FindPassword";
        private const string SEND = "Send";
        private const string USER_AND_EMAIL_NOT_MATCH = "UserAndEmailNotMatch";
        private const string SEND_EMAIL_ADDRESS = "marioli@augmentum.com.cn";
        private const string SENDER_PASSWORD = "memory";
        private const string HOST = "mail2.augmentum.com.cn";
        private const string TITLE = "NewPassword";
        private const string CONTENT_ONE = "ContentOne";
        private const string EMAIL_HAS_SEND = "EmailHasSend";
        private const string EMAIL_SEND_FAIL = "EmailFail";
        private const string RESEND = "Resend";
        private const string HAS_SEND_MAIL = "HasSendEmail";

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public const int VM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public FillUserInfoForm()
        {
            InitializeComponent();

            //globalization
            this.lblTitle.Text = ResourceCulture.GetString(FIND_PASSORD);
            this.btnFind.Text = ResourceCulture.GetString(SEND);
            this.lblUserName.Text = ResourceCulture.GetString(USERNAME);
            this.lblEmail.Text = ResourceCulture.GetString(EMAIl);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.DialogResult = DialogResult.OK;
        }

        public TextBox GetUserNameTxt()
        {
            return this.txtUsername;
        }

        public TextBox GetEmailTxt()
        {
            return this.txtEmail;
        }

        public Label GetSendLabel()
        {
            return this.btnFind;
        }

        /// <summary>
        /// send email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            CancelEventArgs cea = new CancelEventArgs();
            txtUsername_Validating(sender, cea);
            txtEmail_Validating(sender, cea);

            if (cea.Cancel == false)
            {
                UserService.UserServiceClient client = new UserService.UserServiceClient();
                bool result = client.ValidateUserAndEmail(this.txtUsername.Text.Trim(), this.txtEmail.Text.Trim());

                //If has sent email, refuse send again in one minute.
                if (FormPassValue.isSendEmail)
                {
                    TipForm tipForm = new TipForm();
                    tipForm.SetMessage(ResourceCulture.GetString(HAS_SEND_MAIL));
                    tipForm.SetIsShowCancel(false);
                    tipForm.ShowDialog();

                    this.DialogResult = DialogResult.OK;
                    this.Owner.Show();
                    return;
                }

                //validate user pass
                if (result == true)
                {
                    Guid guid = Guid.NewGuid();
                    string verificationCode = guid.ToString().Substring(0, 8);

                    bool isSuccess = SendEmail.SendingEmail(SEND_EMAIL_ADDRESS, SENDER_PASSWORD, this.txtEmail.Text.Trim(),
                        ResourceCulture.GetString(TITLE), ResourceCulture.GetString(CONTENT_ONE) + verificationCode, HOST);

                    if (isSuccess)
                    {
                        FormPassValue.isSendEmail = true;

                        TipForm tipForm = new TipForm();
                        tipForm.SetMessage(ResourceCulture.GetString(EMAIL_HAS_SEND));
                        tipForm.SetIsShowCancel(false);
                        tipForm.IsOpenTimer(true);
                        DialogResult tipResult = tipForm.ShowDialog();

                        if (tipResult == DialogResult.OK || tipResult == DialogResult.Cancel)
                        {
                            tipForm.GetCustomTimer().GetTimer().Enabled = false;

                            ResetPassword form = new ResetPassword();
                            form.SetVerificationCode(verificationCode);
                            form.SetUserName(this.txtUsername.Text.Trim());
                            form.SetEMail(this.txtEmail.Text.Trim());
                            form.SetCount(tipForm.GetCustomTimer().GetCount());
                            form.OpenTimer();
                            form.ShowDialog(this.Owner);

                            this.DialogResult = DialogResult.OK;
                        }
                        // time out
                        else if (tipResult == DialogResult.Ignore)
                        {
                            this.btnFind.Text = ResourceCulture.GetString(RESEND);
                        }
                    }
                    else
                    {
                        TipForm tipForm = new TipForm();
                        tipForm.SetMessage(ResourceCulture.GetString(EMAIL_SEND_FAIL));
                        tipForm.SetIsShowCancel(false);
                        tipForm.ShowDialog();

                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    this.lblErrorMessage.Text = ResourceCulture.GetString(USER_AND_EMAIL_NOT_MATCH);
                    this.lblErrorMessage.Show();
                }
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtUsername.Text.Trim().Equals(string.Empty))
            {
                this.lblErrorMessage.Text = ResourceCulture.GetString(USER_NAME_REQ);
                this.lblErrorMessage.Visible = true;
                e.Cancel = true;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            this.lblErrorMessage.Hide();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            this.lblErrorMessage.Hide();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtEmail.Text.Trim().Equals(string.Empty))
            {
                if (this.lblErrorMessage.Text.Equals(ResourceCulture.GetString(USER_NAME_REQ)))
                {
                    this.lblErrorMessage.Text = ResourceCulture.GetString(USERNAME_AND_PASSWORD);
                }
                else
                {
                    this.lblErrorMessage.Text = ResourceCulture.GetString(EMAIL_REQ);
                }

                this.lblErrorMessage.Visible = true;
                e.Cancel = true;
            }
        }

        private void FillUserInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 13)
            {
                btnFind_Click(null, null);
            }
        }

        //support move
        private void FillUserInfoForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, VM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
    }
}
