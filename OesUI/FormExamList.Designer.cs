using System.Drawing;
using OesUI.Custom;
namespace OesUI
{
    partial class FormExamList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExamList));
            this.splitExamBlock = new System.Windows.Forms.SplitContainer();
            this.lblMyExam = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblUserIcon = new System.Windows.Forms.Label();
            this.pnlMyExam = new OesUI.Custom.MyExam();
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.pnlContact = new System.Windows.Forms.Panel();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.lblContactContent = new System.Windows.Forms.Label();
            this.pnlSysInfo = new System.Windows.Forms.Panel();
            this.lblSystemInfoTitle = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblsys = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.pnlRules = new System.Windows.Forms.Panel();
            this.lblexamnation = new System.Windows.Forms.Label();
            this.labell = new System.Windows.Forms.Label();
            this.lbll = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.llb = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.labb = new System.Windows.Forms.Label();
            this.lblNotices = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rtsContact = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rtsSystem = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rtsRules = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pnlNotice = new System.Windows.Forms.Panel();
            this.pnlNoticeContent = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoticetitle = new System.Windows.Forms.Label();
            this.labee = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lbllinetop = new System.Windows.Forms.Label();
            this.labels = new System.Windows.Forms.Label();
            this.lblNotice = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.customTipDialog1 = new OesUI.Custom.CustomTipDialog();
            this.myOpaqueLayer = new OesUI.Custom.MyOpaqueLayer();
            this.titleBar1 = new OesUI.Custom.TitleBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitExamBlock)).BeginInit();
            this.splitExamBlock.Panel1.SuspendLayout();
            this.splitExamBlock.Panel2.SuspendLayout();
            this.splitExamBlock.SuspendLayout();
            this.pnlStudent.SuspendLayout();
            this.pnlAbout.SuspendLayout();
            this.pnlContact.SuspendLayout();
            this.pnlSysInfo.SuspendLayout();
            this.pnlRules.SuspendLayout();
            this.pnlNotice.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitExamBlock
            // 
            this.splitExamBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitExamBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.splitExamBlock.IsSplitterFixed = true;
            this.splitExamBlock.Location = new System.Drawing.Point(0, 29);
            this.splitExamBlock.Margin = new System.Windows.Forms.Padding(0);
            this.splitExamBlock.Name = "splitExamBlock";
            this.splitExamBlock.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitExamBlock.Panel1
            // 
            this.splitExamBlock.Panel1.BackColor = System.Drawing.Color.White;
            this.splitExamBlock.Panel1.Controls.Add(this.lblMyExam);
            this.splitExamBlock.Panel1.Controls.Add(this.lblLogout);
            this.splitExamBlock.Panel1.Controls.Add(this.lblHome);
            this.splitExamBlock.Panel1.Controls.Add(this.lblLanguage);
            this.splitExamBlock.Panel1.Controls.Add(this.lblCurrentUser);
            this.splitExamBlock.Panel1.Controls.Add(this.lblUserIcon);
            this.splitExamBlock.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitExamBlock.Panel1MinSize = 30;
            // 
            // splitExamBlock.Panel2
            // 
            this.splitExamBlock.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.splitExamBlock.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitExamBlock.Panel2.Controls.Add(this.pnlMyExam);
            this.splitExamBlock.Panel2.Controls.Add(this.pnlStudent);
            this.splitExamBlock.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitExamBlock.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitExamBlock.Size = new System.Drawing.Size(1024, 738);
            this.splitExamBlock.SplitterDistance = 41;
            this.splitExamBlock.SplitterWidth = 1;
            this.splitExamBlock.TabIndex = 0;
            // 
            // lblMyExam
            // 
            this.lblMyExam.BackColor = System.Drawing.Color.White;
            this.lblMyExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMyExam.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblMyExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblMyExam.Location = new System.Drawing.Point(116, 1);
            this.lblMyExam.Name = "lblMyExam";
            this.lblMyExam.Size = new System.Drawing.Size(100, 40);
            this.lblMyExam.TabIndex = 4;
            this.lblMyExam.Text = "My Exam";
            this.lblMyExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMyExam.Click += new System.EventHandler(this.LblMyExam_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblLogout.Location = new System.Drawing.Point(945, 17);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(55, 16);
            this.lblLogout.TabIndex = 3;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.LblLogout_Click);
            // 
            // lblHome
            // 
            this.lblHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblHome.Location = new System.Drawing.Point(16, 1);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(100, 40);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHome.Click += new System.EventHandler(this.LblHome_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLanguage.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblLanguage.Location = new System.Drawing.Point(881, 18);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(60, 16);
            this.lblLanguage.TabIndex = 2;
            this.lblLanguage.Text = "中文";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLanguage.Click += new System.EventHandler(this.LblLanguage_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCurrentUser.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.lblCurrentUser.Location = new System.Drawing.Point(830, 18);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(58, 16);
            this.lblCurrentUser.TabIndex = 1;
            this.lblCurrentUser.Text = "Mario.Li";
            this.lblCurrentUser.Click += new System.EventHandler(this.LblCurrentUser_Click);
            // 
            // lblUserIcon
            // 
            this.lblUserIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("lblUserIcon.Image")));
            this.lblUserIcon.Location = new System.Drawing.Point(802, 14);
            this.lblUserIcon.Name = "lblUserIcon";
            this.lblUserIcon.Size = new System.Drawing.Size(18, 20);
            this.lblUserIcon.TabIndex = 0;
            // 
            // pnlMyExam
            // 
            this.pnlMyExam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMyExam.BackColor = System.Drawing.Color.White;
            this.pnlMyExam.Location = new System.Drawing.Point(20, 27);
            this.pnlMyExam.Name = "pnlMyExam";
            this.pnlMyExam.Size = new System.Drawing.Size(980, 640);
            this.pnlMyExam.TabIndex = 1;
            this.pnlMyExam.Visible = false;
            // 
            // pnlStudent
            // 
            this.pnlStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStudent.BackColor = System.Drawing.Color.White;
            this.pnlStudent.Controls.Add(this.pnlAbout);
            this.pnlStudent.Controls.Add(this.pnlNotice);
            this.pnlStudent.Controls.Add(this.lblLine);
            this.pnlStudent.Controls.Add(this.lbllinetop);
            this.pnlStudent.Controls.Add(this.labels);
            this.pnlStudent.Controls.Add(this.lblNotice);
            this.pnlStudent.Controls.Add(this.lblAbout);
            this.pnlStudent.Location = new System.Drawing.Point(20, 27);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(980, 640);
            this.pnlStudent.TabIndex = 0;
            // 
            // pnlAbout
            // 
            this.pnlAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAbout.BackColor = System.Drawing.Color.White;
            this.pnlAbout.Controls.Add(this.pnlContact);
            this.pnlAbout.Controls.Add(this.pnlSysInfo);
            this.pnlAbout.Controls.Add(this.lblContact);
            this.pnlAbout.Controls.Add(this.lblsys);
            this.pnlAbout.Controls.Add(this.lblRules);
            this.pnlAbout.Controls.Add(this.pnlRules);
            this.pnlAbout.Controls.Add(this.labb);
            this.pnlAbout.Controls.Add(this.lblNotices);
            this.pnlAbout.Controls.Add(this.shapeContainer1);
            this.pnlAbout.Location = new System.Drawing.Point(198, 1);
            this.pnlAbout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(782, 640);
            this.pnlAbout.TabIndex = 20;
            this.pnlAbout.Visible = false;
            // 
            // pnlContact
            // 
            this.pnlContact.Controls.Add(this.lblContactTitle);
            this.pnlContact.Controls.Add(this.lblContactContent);
            this.pnlContact.Location = new System.Drawing.Point(49, 140);
            this.pnlContact.Name = "pnlContact";
            this.pnlContact.Size = new System.Drawing.Size(700, 354);
            this.pnlContact.TabIndex = 37;
            this.pnlContact.Visible = false;
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContactTitle.Font = new System.Drawing.Font("Arial", 13.5F);
            this.lblContactTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblContactTitle.Location = new System.Drawing.Point(254, 32);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(161, 21);
            this.lblContactTitle.TabIndex = 31;
            this.lblContactTitle.Text = "Contact us";
            this.lblContactTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContactContent
            // 
            this.lblContactContent.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblContactContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblContactContent.Location = new System.Drawing.Point(8, 84);
            this.lblContactContent.Name = "lblContactContent";
            this.lblContactContent.Size = new System.Drawing.Size(689, 60);
            this.lblContactContent.TabIndex = 26;
            this.lblContactContent.Text = resources.GetString("lblContactContent.Text");
            // 
            // pnlSysInfo
            // 
            this.pnlSysInfo.Controls.Add(this.lblSystemInfoTitle);
            this.pnlSysInfo.Controls.Add(this.lblinfo);
            this.pnlSysInfo.Location = new System.Drawing.Point(49, 140);
            this.pnlSysInfo.Name = "pnlSysInfo";
            this.pnlSysInfo.Size = new System.Drawing.Size(700, 354);
            this.pnlSysInfo.TabIndex = 36;
            this.pnlSysInfo.Visible = false;
            // 
            // lblSystemInfoTitle
            // 
            this.lblSystemInfoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSystemInfoTitle.Font = new System.Drawing.Font("Arial", 13.5F);
            this.lblSystemInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblSystemInfoTitle.Location = new System.Drawing.Point(254, 32);
            this.lblSystemInfoTitle.Name = "lblSystemInfoTitle";
            this.lblSystemInfoTitle.Size = new System.Drawing.Size(175, 21);
            this.lblSystemInfoTitle.TabIndex = 31;
            this.lblSystemInfoTitle.Text = "System information";
            this.lblSystemInfoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblinfo.Location = new System.Drawing.Point(6, 84);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(689, 60);
            this.lblinfo.TabIndex = 25;
            this.lblinfo.Text = resources.GetString("lblinfo.Text");
            // 
            // lblContact
            // 
            this.lblContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContact.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.lblContact.Location = new System.Drawing.Point(599, 54);
            this.lblContact.Margin = new System.Windows.Forms.Padding(0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(128, 18);
            this.lblContact.TabIndex = 35;
            this.lblContact.Text = "Contact us";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContact.Click += new System.EventHandler(this.LblContact_Click);
            // 
            // lblsys
            // 
            this.lblsys.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblsys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblsys.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblsys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.lblsys.Location = new System.Drawing.Point(377, 55);
            this.lblsys.Margin = new System.Windows.Forms.Padding(0);
            this.lblsys.Name = "lblsys";
            this.lblsys.Size = new System.Drawing.Size(128, 18);
            this.lblsys.TabIndex = 34;
            this.lblsys.Text = "System information";
            this.lblsys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblsys.Click += new System.EventHandler(this.Lblsys_Click);
            // 
            // lblRules
            // 
            this.lblRules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRules.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.lblRules.Location = new System.Drawing.Point(134, 55);
            this.lblRules.Margin = new System.Windows.Forms.Padding(0);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(120, 18);
            this.lblRules.TabIndex = 33;
            this.lblRules.Text = "Examination rules";
            this.lblRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRules.Click += new System.EventHandler(this.LblRules_Click);
            // 
            // pnlRules
            // 
            this.pnlRules.Controls.Add(this.lblexamnation);
            this.pnlRules.Controls.Add(this.labell);
            this.pnlRules.Controls.Add(this.lbll);
            this.pnlRules.Controls.Add(this.label);
            this.pnlRules.Controls.Add(this.llb);
            this.pnlRules.Controls.Add(this.labe);
            this.pnlRules.Controls.Add(this.lbl);
            this.pnlRules.Location = new System.Drawing.Point(49, 140);
            this.pnlRules.Name = "pnlRules";
            this.pnlRules.Size = new System.Drawing.Size(700, 354);
            this.pnlRules.TabIndex = 31;
            // 
            // lblexamnation
            // 
            this.lblexamnation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblexamnation.Font = new System.Drawing.Font("Arial", 13.5F);
            this.lblexamnation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblexamnation.Location = new System.Drawing.Point(254, 32);
            this.lblexamnation.Name = "lblexamnation";
            this.lblexamnation.Size = new System.Drawing.Size(161, 21);
            this.lblexamnation.TabIndex = 30;
            this.lblexamnation.Text = "Examination Rules";
            this.lblexamnation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Font = new System.Drawing.Font("Arial", 10.5F);
            this.labell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.labell.Location = new System.Drawing.Point(3, 215);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(627, 16);
            this.labell.TabIndex = 29;
            this.labell.Text = "6) if you exists a exam which isn\'t submitted yet, you can continue the exam befo" +
                "re the end of time.";
            // 
            // lbll
            // 
            this.lbll.AutoSize = true;
            this.lbll.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lbll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lbll.Location = new System.Drawing.Point(3, 86);
            this.lbll.Name = "lbll";
            this.lbll.Size = new System.Drawing.Size(443, 16);
            this.lbll.TabIndex = 24;
            this.lbll.Text = "1) Exam taker should take exam between effective time and end time.";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 10.5F);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label.Location = new System.Drawing.Point(3, 192);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(440, 16);
            this.label.TabIndex = 28;
            this.label.Text = "5) When the exam exceeds time limitation, it will submit automatically.";
            // 
            // llb
            // 
            this.llb.AutoSize = true;
            this.llb.Font = new System.Drawing.Font("Arial", 10.5F);
            this.llb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.llb.Location = new System.Drawing.Point(3, 111);
            this.llb.Name = "llb";
            this.llb.Size = new System.Drawing.Size(301, 16);
            this.llb.TabIndex = 25;
            this.llb.Text = "2) You should only see one question at a time.";
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("Arial", 10.5F);
            this.labe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.labe.Location = new System.Drawing.Point(3, 164);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(207, 16);
            this.labe.TabIndex = 27;
            this.labe.Text = "4) The exam has time limitation.";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lbl.Location = new System.Drawing.Point(3, 138);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(376, 16);
            this.lbl.TabIndex = 26;
            this.lbl.Text = "3) Once you submit, you won\'t see the answered question.";
            // 
            // labb
            // 
            this.labb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.labb.Location = new System.Drawing.Point(102, 25);
            this.labb.Margin = new System.Windows.Forms.Padding(0);
            this.labb.Name = "labb";
            this.labb.Size = new System.Drawing.Size(640, 1);
            this.labb.TabIndex = 23;
            // 
            // lblNotices
            // 
            this.lblNotices.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblNotices.Location = new System.Drawing.Point(15, 10);
            this.lblNotices.Name = "lblNotices";
            this.lblNotices.Size = new System.Drawing.Size(83, 23);
            this.lblNotices.TabIndex = 22;
            this.lblNotices.Text = "Notice";
            this.lblNotices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rtsContact,
            this.rtsSystem,
            this.rtsRules});
            this.shapeContainer1.Size = new System.Drawing.Size(782, 640);
            this.shapeContainer1.TabIndex = 32;
            this.shapeContainer1.TabStop = false;
            // 
            // rtsContact
            // 
            this.rtsContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtsContact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.rtsContact.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rtsContact.CornerRadius = 3;
            this.rtsContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtsContact.Location = new System.Drawing.Point(597, 52);
            this.rtsContact.Name = "rtsContact";
            this.rtsContact.SelectionColor = System.Drawing.Color.White;
            this.rtsContact.Size = new System.Drawing.Size(130, 20);
            this.rtsContact.ContextMenuChanged += new System.EventHandler(this.LblContact_Click);
            // 
            // rtsSystem
            // 
            this.rtsSystem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtsSystem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.rtsSystem.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rtsSystem.CornerRadius = 3;
            this.rtsSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtsSystem.Location = new System.Drawing.Point(368, 53);
            this.rtsSystem.Name = "rtsSystem";
            this.rtsSystem.SelectionColor = System.Drawing.Color.White;
            this.rtsSystem.Size = new System.Drawing.Size(141, 20);
            this.rtsSystem.Click += new System.EventHandler(this.Lblsys_Click);
            // 
            // rtsRules
            // 
            this.rtsRules.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.rtsRules.CornerRadius = 3;
            this.rtsRules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtsRules.Location = new System.Drawing.Point(129, 53);
            this.rtsRules.Name = "rtsRules";
            this.rtsRules.SelectionColor = System.Drawing.Color.White;
            this.rtsRules.Size = new System.Drawing.Size(126, 20);
            this.rtsRules.ClientSizeChanged += new System.EventHandler(this.LblRules_Click);
            // 
            // pnlNotice
            // 
            this.pnlNotice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNotice.BackColor = System.Drawing.Color.White;
            this.pnlNotice.Controls.Add(this.pnlNoticeContent);
            this.pnlNotice.Controls.Add(this.lblNoticetitle);
            this.pnlNotice.Controls.Add(this.labee);
            this.pnlNotice.Font = new System.Drawing.Font("Arial", 10.5F);
            this.pnlNotice.Location = new System.Drawing.Point(196, 0);
            this.pnlNotice.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNotice.Name = "pnlNotice";
            this.pnlNotice.Size = new System.Drawing.Size(782, 640);
            this.pnlNotice.TabIndex = 19;
            // 
            // pnlNoticeContent
            // 
            this.pnlNoticeContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNoticeContent.AutoScroll = true;
            this.pnlNoticeContent.BackColor = System.Drawing.Color.White;
            this.pnlNoticeContent.Font = new System.Drawing.Font("Arial", 10.5F);
            this.pnlNoticeContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pnlNoticeContent.Location = new System.Drawing.Point(44, 63);
            this.pnlNoticeContent.Name = "pnlNoticeContent";
            this.pnlNoticeContent.Size = new System.Drawing.Size(711, 564);
            this.pnlNoticeContent.TabIndex = 19;
            // 
            // lblNoticetitle
            // 
            this.lblNoticetitle.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoticetitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblNoticetitle.Location = new System.Drawing.Point(18, 11);
            this.lblNoticetitle.Name = "lblNoticetitle";
            this.lblNoticetitle.Size = new System.Drawing.Size(82, 23);
            this.lblNoticetitle.TabIndex = 18;
            this.lblNoticetitle.Text = "Notice";
            this.lblNoticetitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labee
            // 
            this.labee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.labee.Location = new System.Drawing.Point(104, 26);
            this.labee.Margin = new System.Windows.Forms.Padding(0);
            this.labee.Name = "labee";
            this.labee.Size = new System.Drawing.Size(640, 1);
            this.labee.TabIndex = 21;
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblLine.Location = new System.Drawing.Point(195, -4);
            this.lblLine.Margin = new System.Windows.Forms.Padding(0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(1, 644);
            this.lblLine.TabIndex = 17;
            // 
            // lbllinetop
            // 
            this.lbllinetop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lbllinetop.Location = new System.Drawing.Point(7, 29);
            this.lbllinetop.Name = "lbllinetop";
            this.lbllinetop.Size = new System.Drawing.Size(178, 1);
            this.lbllinetop.TabIndex = 16;
            // 
            // labels
            // 
            this.labels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.labels.Location = new System.Drawing.Point(8, 89);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(178, 1);
            this.labels.TabIndex = 15;
            // 
            // lblNotice
            // 
            this.lblNotice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblNotice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNotice.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblNotice.ForeColor = System.Drawing.Color.White;
            this.lblNotice.Location = new System.Drawing.Point(8, 29);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(178, 30);
            this.lblNotice.TabIndex = 8;
            this.lblNotice.Text = "Notice";
            this.lblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNotice.Click += new System.EventHandler(this.LblNotice_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAbout.BackColor = System.Drawing.Color.White;
            this.lblAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAbout.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblAbout.Location = new System.Drawing.Point(8, 59);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(178, 30);
            this.lblAbout.TabIndex = 9;
            this.lblAbout.Text = "About";
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAbout.Click += new System.EventHandler(this.LblAbout_Click);
            // 
            // customTipDialog1
            // 
            this.customTipDialog1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.customTipDialog1.BackColor = System.Drawing.Color.White;
            this.customTipDialog1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customTipDialog1.Location = new System.Drawing.Point(323, 322);
            this.customTipDialog1.Name = "customTipDialog1";
            this.customTipDialog1.Size = new System.Drawing.Size(400, 200);
            this.customTipDialog1.TabIndex = 3;
            this.customTipDialog1.TipMessage = null;
            this.customTipDialog1.Visible = false;
            // 
            // myOpaqueLayer
            // 
            this.myOpaqueLayer.Alpha = 125;
            this.myOpaqueLayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.myOpaqueLayer.Location = new System.Drawing.Point(3, 33);
            this.myOpaqueLayer.Name = "myOpaqueLayer";
            this.myOpaqueLayer.Size = new System.Drawing.Size(1018, 702);
            this.myOpaqueLayer.TabIndex = 2;
            this.myOpaqueLayer.Text = "myOpaqueLayer1";
            this.myOpaqueLayer.TransparentBG = true;
            this.myOpaqueLayer.Visible = false;
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.White;
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(1024, 30);
            this.titleBar1.TabIndex = 1;
            // 
            // FormExamList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.customTipDialog1);
            this.Controls.Add(this.myOpaqueLayer);
            this.Controls.Add(this.titleBar1);
            this.Controls.Add(this.splitExamBlock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormExamList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Augmentum Online Exam System Client";
            this.Load += new System.EventHandler(this.FormExamList_Load);
            this.splitExamBlock.Panel1.ResumeLayout(false);
            this.splitExamBlock.Panel1.PerformLayout();
            this.splitExamBlock.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitExamBlock)).EndInit();
            this.splitExamBlock.ResumeLayout(false);
            this.pnlStudent.ResumeLayout(false);
            this.pnlAbout.ResumeLayout(false);
            this.pnlContact.ResumeLayout(false);
            this.pnlSysInfo.ResumeLayout(false);
            this.pnlRules.ResumeLayout(false);
            this.pnlRules.PerformLayout();
            this.pnlNotice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitExamBlock;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.Label lblMyExam;
        private System.Windows.Forms.Panel pnlStudent;
        private Custom.MyExam pnlMyExam;

        public Custom.MyExam GetPnlMyExam()
        {
            return this.pnlMyExam;
        }

        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label labels;
        private System.Windows.Forms.Label lbllinetop;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblNoticetitle;
        private System.Windows.Forms.Panel pnlNotice;
        private System.Windows.Forms.FlowLayoutPanel pnlNoticeContent;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Label labee;
        private System.Windows.Forms.Label labb;
        private System.Windows.Forms.Label lblNotices;
        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label llb;
        private System.Windows.Forms.Label lbll;
        private System.Windows.Forms.Label lblexamnation;
        private System.Windows.Forms.Panel pnlRules;
        private System.Windows.Forms.Label lblRules;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rtsRules;
        private System.Windows.Forms.Label lblsys;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rtsSystem;
        private System.Windows.Forms.Label lblContact;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rtsContact;
        private Custom.TitleBar titleBar1;
        private System.Windows.Forms.Panel pnlSysInfo;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Panel pnlContact;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Label lblContactContent;
        private System.Windows.Forms.Label lblSystemInfoTitle;
        private Custom.MyOpaqueLayer myOpaqueLayer;
        private CustomTipDialog customTipDialog1;
    }
}

