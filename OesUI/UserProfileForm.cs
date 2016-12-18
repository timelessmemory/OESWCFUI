using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using OesUI.utils;

namespace OesUI
{
    public delegate void Home_Exam_Click(object sender, EventArgs e);

    public partial class UserProfileForm : Form
    {
        public event Home_Exam_Click HomeClick;
        public event Home_Exam_Click ExamClick;
        private const string PASSWORD_TOO_LONG = "PasswordTooLong";
        private const string PIC_TOO_BIG = "PicTooBig";
        private const string PREFIX = "YT00";
        private const string HOME = "home";
        private const string MY_EXAM = "myExam";
        private const string BASIC_INFORMAION = "BasicInformaion";
        private const string CHANGE_PASSWORD = "ChangePassword";
        private const string ADD_PHOTO = "AddPhoto";
        private const string SET_AVATAR = "SetAvatar";
        private const string CHANGE_PASSWORD_SUCCESS = "ChangePasswordSuccess";
        private const string NOT_CONSISTENT = "NotConsistent";
        private const string PASSWORD_CONFIRM = "PasswordConfirm";
        private const string INPUT_PASSWORD = "InputPassword";
        private const string CANCEL = "Cancel";
        private const string CHINESE_NAME = "ChineseName";
        private const string GENDER = "Gender";
        private const string ROLE_TYPE = "RoleType";
        private const string TELEPHONE_NUMBER = "TelephoneNumber";
        private const string EMAIL = "Email";
        private const string USERNAMES = "UserNames";
        private const string USERNAME = "userName";
        private const string PASSWORD = "password";
        private const string ID = "id";
        private const string SUBMITS = "Submits";
        private const string EXAMLIST = "examList";
        private Color color = Color.FromArgb(46, 67, 88);
        private Point btnAddPosition = new Point(226, 350);
        private Point btnAddChangedPosition = new Point(141, 350);
        private UserService.UserServiceClient userManager;
        private int maxSize = 524288;
        private int maxPassLength = 10;

        public UserProfileForm()
        {
            InitializeComponent();

            if (FormPassValue.whichRole == Constants.Teacher_Role)
            {
                this.lblHome.Hide();
                this.lblMyExam.Hide();
                this.lblExamList.Show();
            }

            //set language environment
            Thread.CurrentThread.CurrentCulture = new CultureInfo(FormPassValue.languageState);
            SetResourceCulture();

            if (Process.GetCurrentProcess().ProcessName != "devenv")
            {
                userManager = new UserService.UserServiceClient();
                var table = userManager.GetUserInformation(RememberUserParameter.userId);

                foreach (var item in table)
                {
                    this.lblUsernameValue.Text = item.UserName;
                    this.lblChineseNameValue.Text = item.ChineseName;
                    this.lblGenderValue.Text = item.Gender;
                    this.lblIdValue.Text = item.ID.ToString();
                    this.lblRoleValue.Text = item.RoleType;
                    this.lblTelephoneValue.Text = item.TelephoneNumber;
                    this.lblEmailValue.Text = item.EMail;
                    if (item.IsPicNull() == false)
                    {
                        byte[] pic = item.Pic;
                        MemoryStream ms = new MemoryStream(pic);
                        this.pbuserPhoto.Image = Image.FromStream(ms);
                        this.pbShowPhoto.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        //globalization
        private void SetResourceCulture()
        {
            this.lblLanguage.Text = ResourceCulture.GetString(Constants.LANGUAGE);
            this.lblHome.Text = ResourceCulture.GetString(HOME);
            this.lblMyExam.Text = ResourceCulture.GetString(MY_EXAM);
            this.lblExamList.Text = ResourceCulture.GetString(EXAMLIST);
            this.lblLogout.Text = ResourceCulture.GetString(Constants.LOGOUT);
            this.lblUserInfoTab.Text = ResourceCulture.GetString(BASIC_INFORMAION);
            this.lblChangePassword.Text = ResourceCulture.GetString(CHANGE_PASSWORD);
            this.lblInformation.Text = ResourceCulture.GetString(BASIC_INFORMAION);
            this.lblBasic.Text = ResourceCulture.GetString(BASIC_INFORMAION);
            this.lblUsernameKey.Text = ResourceCulture.GetString(USERNAMES);
            this.lblChineseNameKey.Text = ResourceCulture.GetString(CHINESE_NAME);
            this.lblIDLeft.Text = ResourceCulture.GetString(ID);
            this.lblGenderLeft.Text = ResourceCulture.GetString(GENDER);
            this.lblRoleTypeLeft.Text = ResourceCulture.GetString(ROLE_TYPE);
            this.lblTelephoneNumberLeft.Text = ResourceCulture.GetString(TELEPHONE_NUMBER);
            this.lblEmailLeft.Text = ResourceCulture.GetString(EMAIL);
            this.lblNotConsist.Text = ResourceCulture.GetString(NOT_CONSISTENT);
            this.lblChpUserName.Text = ResourceCulture.GetString(USERNAME);
            this.lblPassword.Text = ResourceCulture.GetString(PASSWORD);
            this.lblConfirmPasssword.Text = ResourceCulture.GetString(PASSWORD_CONFIRM);
            this.lblErrorMessage.Text = ResourceCulture.GetString(INPUT_PASSWORD);
            this.lblErrorMessageTwo.Text = ResourceCulture.GetString(INPUT_PASSWORD);
            this.lblCancel.Text = ResourceCulture.GetString(CANCEL);
            this.lblSubmit.Text = ResourceCulture.GetString(SUBMITS);
            this.btnAdd.Text = ResourceCulture.GetString(ADD_PHOTO);
            this.btnSubmit.Text = ResourceCulture.GetString(SET_AVATAR);
            this.customTipDialog.TipMessage = ResourceCulture.GetString(CHANGE_PASSWORD_SUCCESS);
            this.customTipDialog.ChangeLanguage();
        }

        private void LblLanguage_Click(object sender, EventArgs e)
        {
            if (this.lblLanguage.Text.Equals(Constants.ENGLISH))
            {
                ResourceCulture.SetCurrentCulture(Constants.EN);
            }
            else
            {
                ResourceCulture.SetCurrentCulture(Constants.CH);
            }

            this.SetResourceCulture();
        }

        /// <summary>
        /// Return Home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblHome_Click(object sender, EventArgs e)
        {
            if (HomeClick != null)
            {
                HomeClick(this, new EventArgs());
            }

            this.Close();
        }

        /// <summary>
        /// Return Exam
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblMyExam_Click(object sender, EventArgs e)
        {
            if (ExamClick != null)
            {
                ExamClick(this, new EventArgs());
            }

            this.Close();
        }

        private void LblUserInfoTab_Click(object sender, EventArgs e)
        {
            EmptyInput();
            ShowUserTab();
        }

        private void LblChangePassword_Click(object sender, EventArgs e)
        {
            this.pnlInformation.Hide();
            this.pnlChangePassword.Show();
            this.pnlPhoto.Hide();

            this.lblChangePassword.BackColor = color;
            this.lblChangePassword.ForeColor = Color.White;

            this.lblUserInfoTab.BackColor = Color.White;
            this.lblUserInfoTab.ForeColor = color;
        }

        private void ShowUserTab()
        {
            this.pnlInformation.Show();
            this.pnlChangePassword.Hide();
            this.pnlPhoto.Hide();

            this.lblUserInfoTab.BackColor = color;
            this.lblUserInfoTab.ForeColor = Color.White;

            this.lblChangePassword.BackColor = Color.White;
            this.lblChangePassword.ForeColor = color;
        }

        private void LblCancel_Click(object sender, EventArgs e)
        {
            EmptyInput();
            ShowUserTab();
        }

        private void EmptyInput()
        {
            this.lblErrorMessage.Hide();
            this.lblErrorMessageTwo.Hide();
            this.lblNotConsist.Hide();
            this.txtPassword.Text = string.Empty;
            this.txtPasswordTwo.Text = string.Empty;
        }

        private void LblSubmit_Click(object sender, EventArgs e)
        {
            ValidateAndSubmit();
        }

        private void ValidateAndSubmit()
        {
            this.lblErrorMessage.Hide();
            this.lblErrorMessageTwo.Hide();
            this.lblNotConsist.Hide();

            bool flag = true;
            if (this.txtPassword.Text.Trim().Equals(string.Empty))
            {
                this.lblErrorMessage.Text = ResourceCulture.GetString(INPUT_PASSWORD); ;
                this.lblErrorMessage.Show();
                flag = false;
            }

            if (this.txtPasswordTwo.Text.Trim().Equals(string.Empty))
            {
                this.lblErrorMessageTwo.Text = ResourceCulture.GetString(INPUT_PASSWORD);
                this.lblErrorMessageTwo.Show();
                flag = false;
            }

            if (!this.txtPassword.Text.Trim().Equals(this.txtPasswordTwo.Text.Trim()) && !this.txtPassword.Text.Trim().Equals(string.Empty)
                && !this.txtPasswordTwo.Text.Trim().Equals(string.Empty))
            {
                this.lblNotConsist.Show();
                flag = false;
            }

            if (!this.txtPassword.Text.Trim().Equals(string.Empty) && this.txtPassword.Text.Trim().Length > maxPassLength)
            {
                this.lblErrorMessage.Text = ResourceCulture.GetString(PASSWORD_TOO_LONG);
                this.lblErrorMessage.Show();
            }

            if (!this.txtPasswordTwo.Text.Trim().Equals(string.Empty) && this.txtPasswordTwo.Text.Trim().Length > maxPassLength)
            {
                this.lblErrorMessageTwo.Text = ResourceCulture.GetString(PASSWORD_TOO_LONG);
                this.lblErrorMessageTwo.Show();
            }

            if (!flag)
            {
                return;
            }
            else
            {
                string encryptPassword = EncryptUtils.EncryptPassword(this.txtPassword.Text.Trim());
                userManager.UpdatePassword(encryptPassword, RememberUserParameter.userId);

                this.myOpaqueLayer.Show();
                this.customTipDialog.Tag = this.myOpaqueLayer;
                this.customTipDialog.TipMessage = ResourceCulture.GetString(CHANGE_PASSWORD_SUCCESS);
                this.customTipDialog.Show();
                this.txtPassword.Text = string.Empty;
                this.txtPasswordTwo.Text = string.Empty;
                this.customTipDialog.Focus();
            }
        }

        private void UserProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void TxtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            this.lblErrorMessage.Hide();
            this.lblNotConsist.Hide();
        }

        private void TxtPasswordTwo_MouseClick(object sender, MouseEventArgs e)
        {
            this.lblErrorMessageTwo.Hide();
            this.lblNotConsist.Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.btnSubmit.Hide();
            this.btnAdd.Location = btnAddPosition;
            this.pnlPhoto.Show();
        }

        //choose photo
        private void Button_Click(object sender, EventArgs e)
        {
            if (this.ofd.ShowDialog() == DialogResult.OK)
            {
                if (this.ofd.FileName.Length > maxSize)
                {
                    this.customTipDialog.TipMessage = ResourceCulture.GetString(PIC_TOO_BIG); ;
                    return;
                }
                try
                {
                    this.pbShowPhoto.Image = Image.FromFile(this.ofd.FileName);
                    this.btnAdd.Location = btnAddChangedPosition;
                    this.btnSubmit.Show();
                }
                catch(Exception ex)
                {
                    Log4NetHelper.WriteErrorLog(typeof(UserProfileForm), ex);
                }
            }
            this.btnAdd.Enabled = false;
            this.btnAdd.Enabled = true;
        }

        //change avatar
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ofd.FileName.Equals(string.Empty))
                {
                    MemoryStream ms = new MemoryStream();
                    this.pbShowPhoto.Image.Save(ms, ImageFormat.Jpeg);
                    ms.Position = 0;
                    UserService.UserServiceClient userManager = new UserService.UserServiceClient();
                    userManager.UpdatePhoto(RememberUserParameter.userId, ms.ToArray());
                    this.pbuserPhoto.Image = Image.FromFile(this.ofd.FileName);
                    this.pnlPhoto.Hide();
                }
            }
            catch(Exception ex)
            {
                Log4NetHelper.WriteErrorLog(typeof(UserProfileForm), ex);
            }
        }

        private void LblCloseAvatar_Click(object sender, EventArgs e)
        {
            this.pnlPhoto.Hide();
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormPassValue.currentWindowState;
            this.lblUserName.Text = RememberUserParameter.username;
            this.lblId.Text = PREFIX + RememberUserParameter.userId;
            this.lblCurrentUser.Text = RememberUserParameter.username;
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ValidateAndSubmit();
                return;
            }

            if (e.KeyValue == 32)
            {
                this.txtPassword.Text = this.txtPassword.Text.Trim();

                this.txtPasswordTwo.Text = this.txtPasswordTwo.Text.Trim();
                this.customTipDialog.TipMessage = ResourceCulture.GetString(Constants.NO_SPACE);
                this.myOpaqueLayer.Show();
                this.customTipDialog.Tag = this.myOpaqueLayer;
                this.customTipDialog.Show();
            }
        }

        //logout
        private void LblLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void LblExamList_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
