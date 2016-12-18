namespace OesUI.TeacherUI
{
    partial class ExamDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamDetailForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlExamDetail = new System.Windows.Forms.Panel();
            this.LabelLine = new System.Windows.Forms.Label();
            this.tpl = new System.Windows.Forms.TableLayoutPanel();
            this.panel = new System.Windows.Forms.Panel();
            this.lblNo = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.lblNameDecrease = new System.Windows.Forms.Label();
            this.lblNameIncrease = new System.Windows.Forms.Label();
            this.lblAttend = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbll = new System.Windows.Forms.Label();
            this.pmll = new System.Windows.Forms.Panel();
            this.lblScoreIncrease = new System.Windows.Forms.Label();
            this.lblScoreDecrease = new System.Windows.Forms.Label();
            this.llbl = new System.Windows.Forms.Label();
            this.ppnl = new System.Windows.Forms.Panel();
            this.lblResultIncrease = new System.Windows.Forms.Label();
            this.lblResultDecrease = new System.Windows.Forms.Label();
            this.lblls = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnlPagination = new System.Windows.Forms.FlowLayoutPanel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rtlSearch = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.dgvExamDetail = new System.Windows.Forms.DataGridView();
            this.customTipDialog1 = new OesUI.Custom.CustomTipDialog();
            this.myOpaqueLayer = new OesUI.Custom.MyOpaqueLayer();
            this.titleBar1 = new OesUI.Custom.TitleBar();
            this.pnlExamDetail.SuspendLayout();
            this.tpl.SuspendLayout();
            this.panel.SuspendLayout();
            this.pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pmll.SuspendLayout();
            this.ppnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlExamDetail
            // 
            this.pnlExamDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlExamDetail.BackColor = System.Drawing.Color.White;
            this.pnlExamDetail.Controls.Add(this.LabelLine);
            this.pnlExamDetail.Controls.Add(this.tpl);
            this.pnlExamDetail.Controls.Add(this.lblLine);
            this.pnlExamDetail.Controls.Add(this.lblSearchIcon);
            this.pnlExamDetail.Controls.Add(this.tbSearch);
            this.pnlExamDetail.Controls.Add(this.pnlPagination);
            this.pnlExamDetail.Controls.Add(this.shapeContainer1);
            this.pnlExamDetail.Controls.Add(this.dgvExamDetail);
            this.pnlExamDetail.Location = new System.Drawing.Point(20, 50);
            this.pnlExamDetail.Name = "pnlExamDetail";
            this.pnlExamDetail.Size = new System.Drawing.Size(980, 680);
            this.pnlExamDetail.TabIndex = 38;
            // 
            // LabelLine
            // 
            this.LabelLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.LabelLine.Location = new System.Drawing.Point(0, 72);
            this.LabelLine.Name = "LabelLine";
            this.LabelLine.Size = new System.Drawing.Size(980, 1);
            this.LabelLine.TabIndex = 54;
            // 
            // tpl
            // 
            this.tpl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tpl.ColumnCount = 5;
            this.tpl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.27273F));
            this.tpl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tpl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tpl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.09091F));
            this.tpl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tpl.Controls.Add(this.panel, 0, 0);
            this.tpl.Controls.Add(this.pnl, 1, 0);
            this.tpl.Controls.Add(this.panel1, 2, 0);
            this.tpl.Controls.Add(this.pmll, 3, 0);
            this.tpl.Controls.Add(this.ppnl, 4, 0);
            this.tpl.Location = new System.Drawing.Point(1, 72);
            this.tpl.Name = "tpl";
            this.tpl.RowCount = 1;
            this.tpl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpl.Size = new System.Drawing.Size(975, 40);
            this.tpl.TabIndex = 53;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblNo);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(3, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(162, 34);
            this.panel.TabIndex = 0;
            // 
            // lblNo
            // 
            this.lblNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblNo.Location = new System.Drawing.Point(0, 0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(162, 34);
            this.lblNo.TabIndex = 31;
            this.lblNo.Text = "No";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.lblNameDecrease);
            this.pnl.Controls.Add(this.lblNameIncrease);
            this.pnl.Controls.Add(this.lblAttend);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(171, 3);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(171, 34);
            this.pnl.TabIndex = 1;
            // 
            // lblNameDecrease
            // 
            this.lblNameDecrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameDecrease.BackColor = System.Drawing.Color.White;
            this.lblNameDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNameDecrease.Image = ((System.Drawing.Image)(resources.GetObject("lblNameDecrease.Image")));
            this.lblNameDecrease.Location = new System.Drawing.Point(120, 9);
            this.lblNameDecrease.Name = "lblNameDecrease";
            this.lblNameDecrease.Size = new System.Drawing.Size(10, 15);
            this.lblNameDecrease.TabIndex = 48;
            this.lblNameDecrease.Tag = "2";
            this.lblNameDecrease.Visible = false;
            this.lblNameDecrease.Click += new System.EventHandler(this.LblNameDecrease_Click);
            // 
            // lblNameIncrease
            // 
            this.lblNameIncrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameIncrease.BackColor = System.Drawing.Color.White;
            this.lblNameIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNameIncrease.Image = ((System.Drawing.Image)(resources.GetObject("lblNameIncrease.Image")));
            this.lblNameIncrease.Location = new System.Drawing.Point(120, 9);
            this.lblNameIncrease.Name = "lblNameIncrease";
            this.lblNameIncrease.Size = new System.Drawing.Size(10, 15);
            this.lblNameIncrease.TabIndex = 51;
            this.lblNameIncrease.Tag = "1";
            this.lblNameIncrease.Click += new System.EventHandler(this.LblNameIncrease_Click);
            // 
            // lblAttend
            // 
            this.lblAttend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAttend.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblAttend.Location = new System.Drawing.Point(0, 0);
            this.lblAttend.Name = "lblAttend";
            this.lblAttend.Size = new System.Drawing.Size(171, 34);
            this.lblAttend.TabIndex = 32;
            this.lblAttend.Text = "Attendance";
            this.lblAttend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(348, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 34);
            this.panel1.TabIndex = 2;
            // 
            // lbll
            // 
            this.lbll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbll.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lbll.Location = new System.Drawing.Point(0, 0);
            this.lbll.Name = "lbll";
            this.lbll.Size = new System.Drawing.Size(82, 34);
            this.lbll.TabIndex = 33;
            this.lbll.Text = "Pass criteria";
            this.lbll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pmll
            // 
            this.pmll.Controls.Add(this.lblScoreIncrease);
            this.pmll.Controls.Add(this.lblScoreDecrease);
            this.pmll.Controls.Add(this.llbl);
            this.pmll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pmll.Location = new System.Drawing.Point(436, 3);
            this.pmll.Name = "pmll";
            this.pmll.Size = new System.Drawing.Size(180, 34);
            this.pmll.TabIndex = 3;
            // 
            // lblScoreIncrease
            // 
            this.lblScoreIncrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScoreIncrease.BackColor = System.Drawing.Color.White;
            this.lblScoreIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblScoreIncrease.Image = ((System.Drawing.Image)(resources.GetObject("lblScoreIncrease.Image")));
            this.lblScoreIncrease.Location = new System.Drawing.Point(144, 10);
            this.lblScoreIncrease.Name = "lblScoreIncrease";
            this.lblScoreIncrease.Size = new System.Drawing.Size(10, 15);
            this.lblScoreIncrease.TabIndex = 47;
            this.lblScoreIncrease.Tag = "1";
            this.lblScoreIncrease.Click += new System.EventHandler(this.LblScoreIncrease_Click);
            // 
            // lblScoreDecrease
            // 
            this.lblScoreDecrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScoreDecrease.BackColor = System.Drawing.Color.White;
            this.lblScoreDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblScoreDecrease.Image = ((System.Drawing.Image)(resources.GetObject("lblScoreDecrease.Image")));
            this.lblScoreDecrease.Location = new System.Drawing.Point(144, 9);
            this.lblScoreDecrease.Name = "lblScoreDecrease";
            this.lblScoreDecrease.Size = new System.Drawing.Size(10, 15);
            this.lblScoreDecrease.TabIndex = 50;
            this.lblScoreDecrease.Tag = "2";
            this.lblScoreDecrease.Visible = false;
            this.lblScoreDecrease.Click += new System.EventHandler(this.LblScoreDecrease_Click);
            // 
            // llbl
            // 
            this.llbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.llbl.Location = new System.Drawing.Point(0, 0);
            this.llbl.Name = "llbl";
            this.llbl.Size = new System.Drawing.Size(180, 34);
            this.llbl.TabIndex = 34;
            this.llbl.Text = "Exam/Total Score";
            this.llbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ppnl
            // 
            this.ppnl.Controls.Add(this.lblResultIncrease);
            this.ppnl.Controls.Add(this.lblResultDecrease);
            this.ppnl.Controls.Add(this.lblls);
            this.ppnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppnl.Location = new System.Drawing.Point(622, 3);
            this.ppnl.Name = "ppnl";
            this.ppnl.Size = new System.Drawing.Size(350, 34);
            this.ppnl.TabIndex = 4;
            // 
            // lblResultIncrease
            // 
            this.lblResultIncrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultIncrease.BackColor = System.Drawing.Color.White;
            this.lblResultIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResultIncrease.Image = ((System.Drawing.Image)(resources.GetObject("lblResultIncrease.Image")));
            this.lblResultIncrease.Location = new System.Drawing.Point(199, 8);
            this.lblResultIncrease.Name = "lblResultIncrease";
            this.lblResultIncrease.Size = new System.Drawing.Size(10, 15);
            this.lblResultIncrease.TabIndex = 52;
            this.lblResultIncrease.Tag = "1";
            this.lblResultIncrease.Click += new System.EventHandler(this.LblResultIncrease_Click);
            // 
            // lblResultDecrease
            // 
            this.lblResultDecrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultDecrease.BackColor = System.Drawing.Color.White;
            this.lblResultDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResultDecrease.Image = ((System.Drawing.Image)(resources.GetObject("lblResultDecrease.Image")));
            this.lblResultDecrease.Location = new System.Drawing.Point(199, 10);
            this.lblResultDecrease.Name = "lblResultDecrease";
            this.lblResultDecrease.Size = new System.Drawing.Size(10, 15);
            this.lblResultDecrease.TabIndex = 49;
            this.lblResultDecrease.Tag = "2";
            this.lblResultDecrease.Visible = false;
            this.lblResultDecrease.Click += new System.EventHandler(this.LblResultDecrease_Click);
            // 
            // lblls
            // 
            this.lblls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblls.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblls.Location = new System.Drawing.Point(0, 0);
            this.lblls.Name = "lblls";
            this.lblls.Size = new System.Drawing.Size(350, 34);
            this.lblls.TabIndex = 35;
            this.lblls.Text = "Result";
            this.lblls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblLine.Location = new System.Drawing.Point(1, 112);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(980, 1);
            this.lblLine.TabIndex = 29;
            // 
            // lblSearchIcon
            // 
            this.lblSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("lblSearchIcon.Image")));
            this.lblSearchIcon.Location = new System.Drawing.Point(189, 36);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.Size = new System.Drawing.Size(15, 20);
            this.lblSearchIcon.TabIndex = 28;
            this.lblSearchIcon.Click += new System.EventHandler(this.LblSearchIcon_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.tbSearch.Location = new System.Drawing.Point(53, 39);
            this.tbSearch.MaxLength = 30;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(130, 14);
            this.tbSearch.TabIndex = 27;
            this.tbSearch.TabStop = false;
            this.tbSearch.Text = "Please input keyword";
            this.tbSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseClick);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // pnlPagination
            // 
            this.pnlPagination.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlPagination.AutoSize = true;
            this.pnlPagination.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPagination.Location = new System.Drawing.Point(360, 576);
            this.pnlPagination.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlPagination.Size = new System.Drawing.Size(604, 54);
            this.pnlPagination.TabIndex = 25;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rtlSearch});
            this.shapeContainer1.Size = new System.Drawing.Size(980, 680);
            this.shapeContainer1.TabIndex = 26;
            this.shapeContainer1.TabStop = false;
            // 
            // rtlSearch
            // 
            this.rtlSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.rtlSearch.CornerRadius = 3;
            this.rtlSearch.Location = new System.Drawing.Point(35, 30);
            this.rtlSearch.Name = "rtlSearch";
            this.rtlSearch.SelectionColor = System.Drawing.Color.White;
            this.rtlSearch.Size = new System.Drawing.Size(180, 30);
            this.rtlSearch.MouseLeave += new System.EventHandler(this.tbSearch_MouseLeave);
            // 
            // dgvExamDetail
            // 
            this.dgvExamDetail.AllowUserToAddRows = false;
            this.dgvExamDetail.AllowUserToDeleteRows = false;
            this.dgvExamDetail.AllowUserToResizeColumns = false;
            this.dgvExamDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dgvExamDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExamDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExamDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExamDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvExamDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExamDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvExamDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExamDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvExamDetail.ColumnHeadersHeight = 40;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExamDetail.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvExamDetail.EnableHeadersVisualStyles = false;
            this.dgvExamDetail.GridColor = System.Drawing.Color.Black;
            this.dgvExamDetail.Location = new System.Drawing.Point(0, 70);
            this.dgvExamDetail.Margin = new System.Windows.Forms.Padding(0);
            this.dgvExamDetail.Name = "dgvExamDetail";
            this.dgvExamDetail.ReadOnly = true;
            this.dgvExamDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExamDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvExamDetail.RowHeadersVisible = false;
            this.dgvExamDetail.RowHeadersWidth = 5;
            this.dgvExamDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dgvExamDetail.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvExamDetail.RowTemplate.Height = 30;
            this.dgvExamDetail.RowTemplate.ReadOnly = true;
            this.dgvExamDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExamDetail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvExamDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExamDetail.Size = new System.Drawing.Size(980, 492);
            this.dgvExamDetail.TabIndex = 4;
            this.dgvExamDetail.TabStop = false;
            this.dgvExamDetail.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExamList_CellMouseEnter);
            this.dgvExamDetail.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExamList_CellMouseLeave);
            this.dgvExamDetail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvExamList_MouseClick);
            // 
            // customTipDialog1
            // 
            this.customTipDialog1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.customTipDialog1.BackColor = System.Drawing.Color.White;
            this.customTipDialog1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customTipDialog1.Location = new System.Drawing.Point(286, 286);
            this.customTipDialog1.Name = "customTipDialog1";
            this.customTipDialog1.Size = new System.Drawing.Size(400, 200);
            this.customTipDialog1.TabIndex = 24;
            this.customTipDialog1.TipMessage = "this is first page";
            this.customTipDialog1.Visible = false;
            // 
            // myOpaqueLayer
            // 
            this.myOpaqueLayer.Alpha = 0;
            this.myOpaqueLayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.myOpaqueLayer.BackColor = System.Drawing.Color.White;
            this.myOpaqueLayer.Location = new System.Drawing.Point(0, 33);
            this.myOpaqueLayer.Name = "myOpaqueLayer";
            this.myOpaqueLayer.Size = new System.Drawing.Size(997, 570);
            this.myOpaqueLayer.TabIndex = 40;
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
            this.titleBar1.TabIndex = 39;
            // 
            // ExamDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.customTipDialog1);
            this.Controls.Add(this.myOpaqueLayer);
            this.Controls.Add(this.titleBar1);
            this.Controls.Add(this.pnlExamDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamDetailForm";
            this.Load += new System.EventHandler(this.ExamDetailForm_Load);
            this.pnlExamDetail.ResumeLayout(false);
            this.pnlExamDetail.PerformLayout();
            this.tpl.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pmll.ResumeLayout(false);
            this.ppnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlExamDetail;
        private System.Windows.Forms.DataGridView dgvExamDetail;
        private Custom.CustomTipDialog customTipDialog1;
        private System.Windows.Forms.FlowLayoutPanel pnlPagination;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rtlSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label llbl;
        private System.Windows.Forms.Label lbll;
        private System.Windows.Forms.Label lblAttend;
        private System.Windows.Forms.Label lblls;
        private System.Windows.Forms.Label lblResultDecrease;
        private System.Windows.Forms.Label lblNameDecrease;
        private System.Windows.Forms.Label lblScoreIncrease;
        private System.Windows.Forms.Label lblResultIncrease;
        private System.Windows.Forms.Label lblNameIncrease;
        private System.Windows.Forms.Label lblScoreDecrease;
        private Custom.TitleBar titleBar1;
        private System.Windows.Forms.TableLayoutPanel tpl;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pmll;
        private System.Windows.Forms.Panel ppnl;
        private Custom.MyOpaqueLayer myOpaqueLayer;
        private System.Windows.Forms.Label LabelLine;
    }
}