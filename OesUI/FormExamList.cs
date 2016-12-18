using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using OesUI.ExamService;
using OesUI.utils;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace OesUI
{
    public partial class FormExamList : Form
    {
        private const string FRAG_STR = ". Please attend the";
        private const string SHORT_LINE = "-";
        private const string FRAGSTRTWO = "exam on ";
        private const string DOT = ".";
        private const string COLON = ":";
        private const string ZERO = "0";
        private const string ZEROTWO = "00";
        private const string BACKSLASH = "\"";
        private const string EMPTY_STR = " at ";
        private const string HOME = "home";
        private const string MY_EXAM = "myExam";
        private const string ALL = "all";
        private const string FINISH = "finished";
        private const string UNFINISH = "unfinished";
        private const string NOTICE = "notice";
        private const string ABOUT = "about";
        private const string RULE = "rule";
        private const string INFO = "information";
        private const string CONTACT = "contact";

        public FormExamList()
        {
            InitializeComponent();

            this.pnlMyExam.SetMyOpaqueLayer(this.myOpaqueLayer, this.customTipDialog1);
            SetResourceCulture();
        }

        private void SetResourceCulture()
        {
            this.lblLanguage.Text = ResourceCulture.GetString(Constants.LANGUAGE);
            this.lblHome.Text = ResourceCulture.GetString(HOME);
            this.lblMyExam.Text = ResourceCulture.GetString(MY_EXAM);
            this.lblLogout.Text = ResourceCulture.GetString(Constants.LOGOUT);
            this.GetPnlMyExam().GetAllLabel().Text = ResourceCulture.GetString(ALL);
            this.GetPnlMyExam().GetFinishedLabel().Text = ResourceCulture.GetString(FINISH);
            this.GetPnlMyExam().GetUnFinishedLabel().Text = ResourceCulture.GetString(UNFINISH);
            this.lblNotice.Text = ResourceCulture.GetString(NOTICE);
            this.lblAbout.Text = ResourceCulture.GetString(ABOUT);
            this.lblRules.Text = ResourceCulture.GetString(RULE);
            this.lblsys.Text = ResourceCulture.GetString(INFO);
            this.lblContact.Text = ResourceCulture.GetString(CONTACT);
            this.lblNotices.Text = ResourceCulture.GetString(NOTICE);
            this.lblNoticetitle.Text = ResourceCulture.GetString(NOTICE);
            this.customTipDialog1.ChangeLanguage();
        }

        //switch language
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

        private void LblHome_Click(object sender, EventArgs e)
        {
            this.lblHome.BackColor = Color.FromArgb(210, 218, 227);
            this.lblMyExam.BackColor = Color.White;
            this.pnlMyExam.Visible = false;
        }

        private void LblMyExam_Click(object sender, EventArgs e)
        {
            this.lblMyExam.BackColor = Color.FromArgb(210, 218, 227);
            this.lblHome.BackColor = Color.White;
            this.pnlMyExam.Visible = true;
        }

        private void LblCurrentUser_Click(object sender, EventArgs e)
        {
            FormPassValue.currentWindowState = this.WindowState;
            FormPassValue.languageState = Thread.CurrentThread.CurrentCulture.ToString();
            FormPassValue.whichRole = Constants.Student_Role;

            UserProfileForm form = new UserProfileForm();
            form.HomeClick += new Home_Exam_Click(LblHome_Click);
            form.ExamClick += new Home_Exam_Click(LblMyExam_Click);
            this.Hide();
            form.ShowDialog(this);
        }

        //logout
        private void LblLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void FormExamList_Load(object sender, EventArgs e)
        {
             LoadExamNotice(RememberUserParameter.userId);
             this.lblCurrentUser.Text = RememberUserParameter.username;
        }

        //Notice content
        private void LoadExamNotice(int userId)
        {
            ExamService.ExamServiceClient examManager = new ExamService.ExamServiceClient();
            ExamDS.ExamNoticeDataTable table = examManager.GetExamNoticeById(userId);
            foreach (var item in table)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.AutoSize = false;
                panel.Height = 20;
                panel.Width = 700;

                Label fragStart = new Label();
                fragStart.Height = 20;
                fragStart.AutoSize = true;
                fragStart.Text = item.No + FRAG_STR;

                Label fragExamName = new Label();
                fragExamName.Height = 20;
                fragExamName.Width = 30;
                fragExamName.AutoSize = true;
                fragExamName.ForeColor = Color.FromArgb(41, 103, 147);
                fragExamName.Text = BACKSLASH + item.exam_name + BACKSLASH;
                fragExamName.Cursor = Cursors.Hand;
                fragExamName.Click += (object sender, EventArgs e) => 
                {
                    FormPassValue.languageState = Thread.CurrentThread.CurrentCulture.ToString();
                    FormPassValue.currentWindowState = this.WindowState;
                    FormPassValue.isNoticeStart = 1;

                    ExamDescription examDescription = new ExamDescription();
                    FormPassValue.examId = item.id;
                    DialogResult result = examDescription.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        FormTakeExam formTakeExam = new FormTakeExam();
                        formTakeExam.Show(this);
                        this.Hide();
                    }
                };

                DateTime dateTime = item.effective_time;
                string yearStr = dateTime.Year + SHORT_LINE + dateTime.Month + SHORT_LINE + dateTime.Day;
                string timeStr = dateTime.Hour + COLON + (dateTime.Minute.ToString().Equals(ZERO) ? ZEROTWO : dateTime.Minute.ToString()) + DOT;

                Label fragEnd = new Label();
                fragEnd.Height = 20;
                fragEnd.AutoSize = true;
                fragEnd.Text = FRAGSTRTWO + yearStr + EMPTY_STR + timeStr;

                panel.Controls.Add(fragStart);
                panel.Controls.Add(fragExamName);
                panel.Controls.Add(fragEnd);

                this.pnlNoticeContent.Controls.Add(panel);
            }
        }

        private void LblNotice_Click(object sender, EventArgs e)
        {
            this.pnlNotice.Show();
            this.pnlAbout.Hide();

            this.lblNotice.BackColor = Color.FromArgb(46, 67, 88);
            this.lblNotice.ForeColor = Color.White;

            this.lblAbout.BackColor = Color.White;
            this.lblAbout.ForeColor = Color.FromArgb(46, 67, 88);
        }

        private void LblAbout_Click(object sender, EventArgs e)
        {
            this.pnlNotice.Hide();
            this.pnlAbout.Show();

            this.lblAbout.BackColor = Color.FromArgb(46, 67, 88);
            this.lblAbout.ForeColor = Color.White;

            this.lblNotice.BackColor = Color.White;
            this.lblNotice.ForeColor = Color.FromArgb(46, 67, 88);
        }

        private void LblRules_Click(object sender, EventArgs e)
        {
            this.rtsRules.BorderStyle = DashStyle.Solid;
            this.pnlRules.Show();

            this.rtsContact.BorderStyle = DashStyle.Custom;
            this.pnlContact.Hide();

            this.rtsSystem.BorderStyle = DashStyle.Custom;
            this.pnlSysInfo.Hide();
        }

        private void Lblsys_Click(object sender, EventArgs e)
        {
            this.rtsRules.BorderStyle = DashStyle.Custom;
            this.pnlRules.Hide();

            this.rtsContact.BorderStyle = DashStyle.Custom;
            this.pnlContact.Hide();

            this.rtsSystem.BorderStyle = DashStyle.Solid;
            this.pnlSysInfo.Show();
        }

        private void LblContact_Click(object sender, EventArgs e)
        {
            this.rtsRules.BorderStyle = DashStyle.Custom;
            this.pnlRules.Hide();

            this.rtsContact.BorderStyle = DashStyle.Solid;
            this.pnlContact.Show();

            this.rtsSystem.BorderStyle = DashStyle.Custom;
            this.pnlSysInfo.Hide();
        }
    }
}
