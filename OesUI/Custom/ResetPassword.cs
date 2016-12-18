using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OesUI.utils;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OesUI.Custom
{
    public partial class ResetPassword : Form
    {
        private const string VERIFICATION_CODE_REQ = "VeriticationCodeReq";
        private const string PASS_REQ = "PasswordIsRequired";
        private const string PASS_TWO_REQ = "PasswordTwoRequired";
        private const string NOT_CONSISTENT = "NotConsistent";
        private const string VALIDATION_CODE_ERROR = "VerificationCodeError";
        private const string RESET_PASWORD = "ResetPassword";
        private const string VERIFICATION_CODE = "VerificationCode";
        private const string PASSWORD = "password";
        private const string PASSWORD_CONFIRM = "PasswordConfirm";
        private const string CONFIRM = "confirm";
        private const string CHANGE_PASSWORD_SUCCESS = "ChangePasswordSuccess";
        private const string CHANGE_PASSWORD_UNSUCCESS = "ChangePasswordUnsuccess";
        private const string RESEND = "Resend";
        private string verificationCode = string.Empty;
        private string userName = string.Empty;
        private string email = string.Empty;
        private int count = 0;
        private int totalTime = 3;
        private int currentTime = 0;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public const int VM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public ResetPassword()
        {
            InitializeComponent();

            SetCulture();
        }

        //globalization
        public void SetCulture()
        {
            this.lblTitle.Text = ResourceCulture.GetString(RESET_PASWORD);
            this.lblVerification.Text = ResourceCulture.GetString(VERIFICATION_CODE);
            this.lblPassword.Text = ResourceCulture.GetString(PASSWORD);
            this.lblPasswordConfirm.Text = ResourceCulture.GetString(PASSWORD_CONFIRM);
            this.btnConfirm.Text = ResourceCulture.GetString(CONFIRM);
        }

        public void SetVerificationCode(string verificationCode)
        {
            this.verificationCode = verificationCode;
        }

        public void SetUserName(string userName)
        {
            this.userName = userName;
        }

        public void SetEMail(string email)
        {
            this.email = email;
        }

        public void SetCount(int count)
        {
            this.count = count;
        }

        //open timer
        public void OpenTimer()
        {
            this.customTimer.DoSomething = DoSomething;
            this.customTimer.GetTimer().Enabled = true;
            this.customTimer.SetCount(this.count);
            this.customTimer.GetTimer().Start();
        }

        //when time limit is over, do something
        public void DoSomething()
        {
            if (this.Owner != null)
            {
                FormPassValue.loginForm = this.Owner;
            }

            FormPassValue.loginForm.Hide();

            FillUserInfoForm form = new FillUserInfoForm();
            form.GetUserNameTxt().Text = this.userName;
            form.GetEmailTxt().Text = this.email;
            form.GetSendLabel().Text = ResourceCulture.GetString(RESEND);
            form.ShowDialog(FormPassValue.loginForm);

            this.DialogResult = DialogResult.OK;
        }

        private void txtCode_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtCode.Text.Trim().Equals(string.Empty))
            {
                this.lblErrorMessage.Text = ResourceCulture.GetString(VERIFICATION_CODE_REQ);
                this.lblErrorMessage.Visible = true;
                e.Cancel = true;
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtPassword.Text.Trim().Equals(string.Empty))
            {
                this.lblErrorMessage.Text = ResourceCulture.GetString(PASS_REQ);
                this.lblErrorMessage.Visible = true;
                e.Cancel = true;
            }
        }

        private void txtPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtPasswordConfirm.Text.Trim().Equals(string.Empty))
            {
                this.lblErrorMessage.Text = ResourceCulture.GetString(PASS_TWO_REQ);
                this.lblErrorMessage.Visible = true;
                e.Cancel = true;
            }
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            this.lblErrorMessage.Hide();
        }

        //reset password 
        private void btnFind_Click(object sender, EventArgs e)
        {
            FormPassValue.loginForm = this.Owner;

            CancelEventArgs cea = new CancelEventArgs();
            txtPasswordConfirm_Validating(sender, cea);
            txtPassword_Validating(sender, cea);
            txtCode_Validating(sender, cea);

            //validate input pass
            if (cea.Cancel == false)
            {
                if (this.txtCode.Text.Trim().Equals(this.verificationCode))
                {
                    if (this.txtPasswordConfirm.Text.Trim().Equals(this.txtPassword.Text.Trim()))
                    {
                        UserService.UserServiceClient client = new UserService.UserServiceClient();
                        int userId = Convert.ToInt32(client.QueryUserIdByName(this.userName));
                        string encryptPassword = EncryptUtils.EncryptPassword(this.txtPassword.Text.Trim());

                        try
                        {
                            client.UpdatePassword(encryptPassword, userId);
                            FormPassValue.isSendEmail = false;

                            this.customTimer.GetTimer().Enabled = false;
                            TipForm tipForm = new TipForm();
                            tipForm.SetMessage(ResourceCulture.GetString(CHANGE_PASSWORD_SUCCESS));
                            tipForm.SetIsShowCancel(false);
                            tipForm.ShowDialog();
                            this.DialogResult = DialogResult.OK;
                            this.Owner.Show();
                        }
                        catch(Exception ex)
                        {
                            Log4NetHelper.WriteErrorLog(typeof(ResetPassword), ex);

                            TipForm tipForm = new TipForm();
                            tipForm.SetMessage(ResourceCulture.GetString(CHANGE_PASSWORD_UNSUCCESS));
                            tipForm.SetIsShowCancel(false);
                            tipForm.ShowDialog();
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        this.lblErrorMessage.Text = ResourceCulture.GetString(NOT_CONSISTENT);
                        this.lblErrorMessage.Show();
                    }
                }
                else
                {
                    this.lblErrorMessage.Text = ResourceCulture.GetString(VALIDATION_CODE_ERROR);
                    this.lblErrorMessage.Show();
                    currentTime++;

                    if (currentTime == totalTime)
                    {
                        this.DialogResult = DialogResult.Cancel;
                        this.Owner.Show();
                    }
                }
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            FormPassValue.loginForm = this.Owner;
            this.Owner.Show();
            this.DialogResult = DialogResult.OK;
        }

        private void ResetPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 13)
            {
                btnFind_Click(null, null);
            }
        }

        //support move
        private void ResetPassword_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, VM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
    }
}
