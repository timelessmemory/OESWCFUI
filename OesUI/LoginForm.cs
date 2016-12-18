using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using OesUI.bean;
using OesUI.UserService;
using OesUI.utils;
using OesUI.Custom;

namespace OesUI
{
    public partial class LoginForm : Form
    {
        private const string NOT_CORRECT_PASS = "notCorrectPass";
        private const string USER_NAME_NOT_EXIST = "userNameNotExist";
        private const string USERNAME = "userName";
        private const string PASSWORD = "password";
        private const string USE_AND_PASSS_REQ = "userAndPasswordRequired";
        private const string PASS_REQ = "passwordRequired";
        private const string USER_NAME_REQ = "userNameRequired";
        private const string LOGIN = "login";
        private const char DOT = '●';
        private const string REM = "rememberMe";
        private const string FORGET = "forgetPassword";
        public const int VM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private const string passwordFilePath = "data.bin";
        private char defaultValue = '\0';
      

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public LoginForm()
        {
            InitializeComponent();
            SetResourceCulture();
        }

        private void SetResourceCulture()
        {
            this.txtUsername.Text = ResourceCulture.GetString(USERNAME);
            this.txtPassword.Text = ResourceCulture.GetString(PASSWORD);
            this.btnLogin.Text = ResourceCulture.GetString(LOGIN);
            this.ckxRemember.Text = ResourceCulture.GetString(REM);
            this.lblForgetPass.Text = ResourceCulture.GetString(FORGET);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            CancelEventArgs cea = new CancelEventArgs();
            UserName_Validating(sender, cea);
            Password_Validating(sender, cea);

            if (cea.Cancel == false)
            {
                UserService.UserServiceClient userManager = new UserService.UserServiceClient();
                try
                {
                    string encryptPassword = EncryptUtils.EncryptPassword(this.txtPassword.Text);
                    bool result = userManager.VerifyUserLogin(this.txtUsername.Text.Trim(), encryptPassword);

                    if (result == true)
                    {
                        RememberUserParameter.username = this.txtUsername.Text.Trim();
                        RememberUserParameter.userId = Convert.ToInt32(userManager.QueryUserIdByName(this.txtUsername.Text.Trim()));

                        //remember password
                        if (this.lblSelect.Visible)
                        {
                            UserInfo user = new UserInfo();
                            user.UserName = this.txtUsername.Text.Trim();
                            user.Password = this.txtPassword.Text.Trim();
                            FileStream fs = new FileStream(passwordFilePath, FileMode.Create);
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Serialize(fs, user);
                            fs.Close();
                        }
                        else
                        {
                            FileStream fs = new FileStream(passwordFilePath, FileMode.Open, FileAccess.Write);
                            if (fs.Length > 0)
                            {
                                fs.SetLength(0);
                                fs.Close();
                            }
                        }

                        Log4NetHelper.WriteInfoLog(typeof(LoginForm), "Login successfully!");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.lblPassErrorMessage.Visible = true;
                        this.lblErrorMessage.Text = ResourceCulture.GetString(NOT_CORRECT_PASS);
                        this.lblErrorMessage.Visible = true;
                        Log4NetHelper.WriteInfoLog(typeof(LoginForm), "Password error!");
                    }
                }
                catch (FaultException<UserNameNotExistent>)
                {
                    this.lblUsernameErrorMessage.Visible = true;
                    this.lblErrorMessage.Text = ResourceCulture.GetString(USER_NAME_NOT_EXIST);
                    this.lblErrorMessage.Visible = true;
                    Log4NetHelper.WriteInfoLog(typeof(LoginForm), "User isn't existent!");
                }
                catch (CommunicationException ex)
                {
                    Log4NetHelper.WriteErrorLog(typeof(LoginForm), ex);
                }
                catch (Exception exx)
                {
                    Log4NetHelper.WriteErrorLog(typeof(LoginForm), exx);
                }
            }
        }

        public bool IsTeacher()
        {
            UserService.UserServiceClient userManager = new UserService.UserServiceClient();
            return userManager.VerifyIsTeacher(RememberUserParameter.userId);
        }

        private void UserName_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtUsername.Text.Length == 0 || this.txtUsername.Text.Equals(ResourceCulture.GetString(USERNAME)))
            {
                this.lblUsernameErrorMessage.Visible = true;
                this.lblErrorMessage.Text = ResourceCulture.GetString(USER_NAME_REQ);
                this.lblErrorMessage.Visible = true;
                e.Cancel = true;
            }
        }

        private void Password_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtPassword.Text.Length == 0 || this.txtPassword.Text.Equals(ResourceCulture.GetString(PASSWORD)))
            {
                this.lblPassErrorMessage.Visible = true;
                if (this.lblErrorMessage.Text.Equals(ResourceCulture.GetString(USER_NAME_REQ)))
                {
                    this.lblErrorMessage.Text = ResourceCulture.GetString(USE_AND_PASSS_REQ);
                }
                else
                {
                    this.lblErrorMessage.Text = ResourceCulture.GetString(PASS_REQ);
                }

                this.lblErrorMessage.Visible = true;
                e.Cancel = true;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (this.txtPassword.Text.Trim().Equals(ResourceCulture.GetString(PASSWORD)))
            {
                this.txtPassword.Text = string.Empty;
            }

            this.lblPassErrorMessage.Visible = false;
            this.lblErrorMessage.Visible = false;
            this.txtPassword.PasswordChar = DOT;
        }

        private void UserName_Enter(object sender, EventArgs e)
        {
            if (this.txtUsername.Text.Trim().Equals(ResourceCulture.GetString(USERNAME)))
            {
                this.txtUsername.Text = string.Empty;
            }

            this.lblUsernameErrorMessage.Visible = false;
            this.lblErrorMessage.Visible = false;
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyValue == 13)
            {
                Login_Click(null, null);
            }

           if (e.KeyValue == 9 && !this.txtPassword.Focused)
           {
               this.txtPassword.Focus();
           }
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PcTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, VM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream(passwordFilePath, FileMode.OpenOrCreate))
                {
                    if (fs.Length > 0)
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        UserInfo user = bf.Deserialize(fs) as UserInfo;
                        this.txtUsername.Text = user.UserName;
                        this.txtPassword.PasswordChar = DOT;
                        this.txtPassword.Text = user.Password;
                    }
                }
            }
            catch(Exception ex)
            {
                Log4NetHelper.WriteErrorLog(typeof(LoginForm), ex);
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (this.txtUsername.Text.Trim().Equals(string.Empty))
            {
                this.txtUsername.Text = ResourceCulture.GetString(USERNAME);
            }
        }

        private void lblSelect_Click(object sender, EventArgs e)
        {
            this.lblSelect.Hide();
            this.lblUnselect.Show();
        }

        private void lblUnselect_Click(object sender, EventArgs e)
        {
            this.lblUnselect.Hide();
            this.lblSelect.Show();
        }

        private void lblForgetPass_Click(object sender, EventArgs e)
        {
            TipForm tipForm = new TipForm();
            DialogResult result = tipForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                FillUserInfoForm form = new FillUserInfoForm();
                this.Hide();
                form.ShowDialog(this);
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtPassword.Text.Trim().Equals(string.Empty))
            {
                this.txtPassword.PasswordChar = defaultValue;
                this.txtPassword.Text = ResourceCulture.GetString(PASSWORD);
            }
        }
    }
}
