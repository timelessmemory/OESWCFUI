namespace OesUI
{
    partial class FormTakeExam
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTakeExam));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblfragmenttwo = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblEachPoint = new System.Windows.Forms.Label();
            this.lblTimeTitle = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblfragmentone = new System.Windows.Forms.Label();
            this.lblQuesNum = new System.Windows.Forms.Label();
            this.lblQuesTitle = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblAnswerA = new System.Windows.Forms.Label();
            this.lblAnswerB = new System.Windows.Forms.Label();
            this.lblAnswerC = new System.Windows.Forms.Label();
            this.lblAnswerD = new System.Windows.Forms.Label();
            this.pnlMainLayout = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBunselect = new System.Windows.Forms.Label();
            this.lblDunselect = new System.Windows.Forms.Label();
            this.lblCunselect = new System.Windows.Forms.Label();
            this.lblCSelect = new System.Windows.Forms.Label();
            this.lblASelect = new System.Windows.Forms.Label();
            this.lblBSelect = new System.Windows.Forms.Label();
            this.lblDSelect = new System.Windows.Forms.Label();
            this.lblAunselect = new System.Windows.Forms.Label();
            this.rbtD = new System.Windows.Forms.Label();
            this.rbtB = new System.Windows.Forms.Label();
            this.rbtC = new System.Windows.Forms.Label();
            this.rbtA = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlExamResult = new System.Windows.Forms.Panel();
            this.lblCorrectCount = new System.Windows.Forms.Label();
            this.lblFragTwo = new System.Windows.Forms.Label();
            this.lblGetScore = new System.Windows.Forms.Label();
            this.lblFragOne = new System.Windows.Forms.Label();
            this.lblViewDetail = new System.Windows.Forms.Label();
            this.lblth = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rt = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pnlAutoResult = new System.Windows.Forms.Panel();
            this.lblAtuoTitle = new System.Windows.Forms.Label();
            this.lbltest = new System.Windows.Forms.Label();
            this.lblAutoCorrectNum = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblAutoGetScore = new System.Windows.Forms.Label();
            this.lblYour = new System.Windows.Forms.Label();
            this.lblAutoSub = new System.Windows.Forms.Label();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.titleBar1 = new OesUI.Custom.TitleBar();
            this.panel1.SuspendLayout();
            this.pnlMainLayout.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlExamResult.SuspendLayout();
            this.pnlAutoResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblfragmenttwo);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.lblEachPoint);
            this.panel1.Controls.Add(this.lblTimeTitle);
            this.panel1.Controls.Add(this.lblPercent);
            this.panel1.Controls.Add(this.lblChoose);
            this.panel1.Controls.Add(this.lblfragmentone);
            this.panel1.Location = new System.Drawing.Point(28, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 50);
            this.panel1.TabIndex = 0;
            // 
            // lblfragmenttwo
            // 
            this.lblfragmenttwo.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfragmenttwo.Location = new System.Drawing.Point(305, 15);
            this.lblfragmenttwo.Name = "lblfragmenttwo";
            this.lblfragmenttwo.Size = new System.Drawing.Size(94, 16);
            this.lblfragmenttwo.TabIndex = 6;
            this.lblfragmenttwo.Text = "points each.";
            this.lblfragmenttwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Arial", 22.5F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.lblTimer.Location = new System.Drawing.Point(766, 2);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(160, 45);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEachPoint
            // 
            this.lblEachPoint.AutoSize = true;
            this.lblEachPoint.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEachPoint.Location = new System.Drawing.Point(286, 16);
            this.lblEachPoint.Name = "lblEachPoint";
            this.lblEachPoint.Size = new System.Drawing.Size(16, 16);
            this.lblEachPoint.TabIndex = 5;
            this.lblEachPoint.Text = "0";
            this.lblEachPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTimeTitle
            // 
            this.lblTimeTitle.AutoSize = true;
            this.lblTimeTitle.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTitle.Location = new System.Drawing.Point(684, 16);
            this.lblTimeTitle.Name = "lblTimeTitle";
            this.lblTimeTitle.Size = new System.Drawing.Size(54, 16);
            this.lblTimeTitle.TabIndex = 3;
            this.lblTimeTitle.Text = "Timing";
            // 
            // lblPercent
            // 
            this.lblPercent.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(466, 16);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(36, 16);
            this.lblPercent.TabIndex = 2;
            this.lblPercent.Text = "1/25";
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(29, 16);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(57, 16);
            this.lblChoose.TabIndex = 0;
            this.lblChoose.Text = "Choice";
            // 
            // lblfragmentone
            // 
            this.lblfragmentone.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfragmentone.Location = new System.Drawing.Point(101, 15);
            this.lblfragmentone.Name = "lblfragmentone";
            this.lblfragmentone.Size = new System.Drawing.Size(184, 16);
            this.lblfragmentone.TabIndex = 1;
            this.lblfragmentone.Text = "Only one correct answer,";
            this.lblfragmentone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuesNum
            // 
            this.lblQuesNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuesNum.Location = new System.Drawing.Point(112, 115);
            this.lblQuesNum.Margin = new System.Windows.Forms.Padding(0);
            this.lblQuesNum.Name = "lblQuesNum";
            this.lblQuesNum.Size = new System.Drawing.Size(20, 20);
            this.lblQuesNum.TabIndex = 1;
            this.lblQuesNum.Text = "1";
            this.lblQuesNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuesTitle
            // 
            this.lblQuesTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuesTitle.Location = new System.Drawing.Point(140, 116);
            this.lblQuesTitle.Name = "lblQuesTitle";
            this.lblQuesTitle.Size = new System.Drawing.Size(800, 20);
            this.lblQuesTitle.TabIndex = 2;
            this.lblQuesTitle.Text = "Which city do you like best?";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial", 10.5F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(419, 470);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 30);
            this.btnNext.TabIndex = 7;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // lblAnswerA
            // 
            this.lblAnswerA.AutoSize = true;
            this.lblAnswerA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAnswerA.Location = new System.Drawing.Point(166, 167);
            this.lblAnswerA.Name = "lblAnswerA";
            this.lblAnswerA.Size = new System.Drawing.Size(99, 19);
            this.lblAnswerA.TabIndex = 8;
            this.lblAnswerA.Text = "ChangZhou";
            // 
            // lblAnswerB
            // 
            this.lblAnswerB.AutoSize = true;
            this.lblAnswerB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAnswerB.Location = new System.Drawing.Point(166, 208);
            this.lblAnswerB.Name = "lblAnswerB";
            this.lblAnswerB.Size = new System.Drawing.Size(80, 19);
            this.lblAnswerB.TabIndex = 9;
            this.lblAnswerB.Text = "NanTong";
            // 
            // lblAnswerC
            // 
            this.lblAnswerC.AutoSize = true;
            this.lblAnswerC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAnswerC.Location = new System.Drawing.Point(166, 247);
            this.lblAnswerC.Name = "lblAnswerC";
            this.lblAnswerC.Size = new System.Drawing.Size(87, 19);
            this.lblAnswerC.TabIndex = 10;
            this.lblAnswerC.Text = "YangZhou";
            // 
            // lblAnswerD
            // 
            this.lblAnswerD.AutoSize = true;
            this.lblAnswerD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAnswerD.Location = new System.Drawing.Point(166, 283);
            this.lblAnswerD.Name = "lblAnswerD";
            this.lblAnswerD.Size = new System.Drawing.Size(84, 19);
            this.lblAnswerD.TabIndex = 11;
            this.lblAnswerD.Text = "ShangHai";
            // 
            // pnlMainLayout
            // 
            this.pnlMainLayout.Controls.Add(this.panel2);
            this.pnlMainLayout.Controls.Add(this.rbtD);
            this.pnlMainLayout.Controls.Add(this.rbtB);
            this.pnlMainLayout.Controls.Add(this.rbtC);
            this.pnlMainLayout.Controls.Add(this.rbtA);
            this.pnlMainLayout.Controls.Add(this.btnSubmit);
            this.pnlMainLayout.Controls.Add(this.panel1);
            this.pnlMainLayout.Controls.Add(this.btnNext);
            this.pnlMainLayout.Controls.Add(this.lblAnswerD);
            this.pnlMainLayout.Controls.Add(this.lblQuesNum);
            this.pnlMainLayout.Controls.Add(this.lblAnswerC);
            this.pnlMainLayout.Controls.Add(this.lblQuesTitle);
            this.pnlMainLayout.Controls.Add(this.lblAnswerB);
            this.pnlMainLayout.Controls.Add(this.lblAnswerA);
            this.pnlMainLayout.Controls.Add(this.shapeContainer2);
            this.pnlMainLayout.Location = new System.Drawing.Point(0, 36);
            this.pnlMainLayout.Name = "pnlMainLayout";
            this.pnlMainLayout.Size = new System.Drawing.Size(1022, 674);
            this.pnlMainLayout.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBunselect);
            this.panel2.Controls.Add(this.lblDunselect);
            this.panel2.Controls.Add(this.lblCunselect);
            this.panel2.Controls.Add(this.lblCSelect);
            this.panel2.Controls.Add(this.lblASelect);
            this.panel2.Controls.Add(this.lblBSelect);
            this.panel2.Controls.Add(this.lblDSelect);
            this.panel2.Controls.Add(this.lblAunselect);
            this.panel2.Location = new System.Drawing.Point(109, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(27, 143);
            this.panel2.TabIndex = 29;
            // 
            // lblBunselect
            // 
            this.lblBunselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBunselect.Image = ((System.Drawing.Image)(resources.GetObject("lblBunselect.Image")));
            this.lblBunselect.Location = new System.Drawing.Point(5, 42);
            this.lblBunselect.Name = "lblBunselect";
            this.lblBunselect.Size = new System.Drawing.Size(18, 18);
            this.lblBunselect.TabIndex = 22;
            this.lblBunselect.Tag = "2";
            this.lblBunselect.Click += new System.EventHandler(this.LblBunselect_Click);
            // 
            // lblDunselect
            // 
            this.lblDunselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDunselect.Image = ((System.Drawing.Image)(resources.GetObject("lblDunselect.Image")));
            this.lblDunselect.Location = new System.Drawing.Point(5, 120);
            this.lblDunselect.Name = "lblDunselect";
            this.lblDunselect.Size = new System.Drawing.Size(18, 18);
            this.lblDunselect.TabIndex = 24;
            this.lblDunselect.Tag = "2";
            this.lblDunselect.Click += new System.EventHandler(this.LblDunselect_Click);
            // 
            // lblCunselect
            // 
            this.lblCunselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCunselect.Image = ((System.Drawing.Image)(resources.GetObject("lblCunselect.Image")));
            this.lblCunselect.Location = new System.Drawing.Point(5, 81);
            this.lblCunselect.Name = "lblCunselect";
            this.lblCunselect.Size = new System.Drawing.Size(18, 18);
            this.lblCunselect.TabIndex = 23;
            this.lblCunselect.Tag = "2";
            this.lblCunselect.Click += new System.EventHandler(this.LblCunselect_Click);
            // 
            // lblCSelect
            // 
            this.lblCSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCSelect.Image = ((System.Drawing.Image)(resources.GetObject("lblCSelect.Image")));
            this.lblCSelect.Location = new System.Drawing.Point(5, 81);
            this.lblCSelect.Name = "lblCSelect";
            this.lblCSelect.Size = new System.Drawing.Size(18, 18);
            this.lblCSelect.TabIndex = 21;
            this.lblCSelect.Tag = "1";
            this.lblCSelect.Visible = false;
            // 
            // lblASelect
            // 
            this.lblASelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblASelect.Image = ((System.Drawing.Image)(resources.GetObject("lblASelect.Image")));
            this.lblASelect.Location = new System.Drawing.Point(5, 4);
            this.lblASelect.Name = "lblASelect";
            this.lblASelect.Size = new System.Drawing.Size(18, 18);
            this.lblASelect.TabIndex = 17;
            this.lblASelect.Tag = "1";
            // 
            // lblBSelect
            // 
            this.lblBSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBSelect.Image = ((System.Drawing.Image)(resources.GetObject("lblBSelect.Image")));
            this.lblBSelect.Location = new System.Drawing.Point(5, 42);
            this.lblBSelect.Name = "lblBSelect";
            this.lblBSelect.Size = new System.Drawing.Size(18, 18);
            this.lblBSelect.TabIndex = 19;
            this.lblBSelect.Tag = "1";
            this.lblBSelect.Visible = false;
            // 
            // lblDSelect
            // 
            this.lblDSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDSelect.Image = ((System.Drawing.Image)(resources.GetObject("lblDSelect.Image")));
            this.lblDSelect.Location = new System.Drawing.Point(5, 120);
            this.lblDSelect.Name = "lblDSelect";
            this.lblDSelect.Size = new System.Drawing.Size(18, 18);
            this.lblDSelect.TabIndex = 20;
            this.lblDSelect.Tag = "1";
            this.lblDSelect.Visible = false;
            // 
            // lblAunselect
            // 
            this.lblAunselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAunselect.Image = ((System.Drawing.Image)(resources.GetObject("lblAunselect.Image")));
            this.lblAunselect.Location = new System.Drawing.Point(5, 4);
            this.lblAunselect.Name = "lblAunselect";
            this.lblAunselect.Size = new System.Drawing.Size(18, 18);
            this.lblAunselect.TabIndex = 18;
            this.lblAunselect.Tag = "2";
            this.lblAunselect.Visible = false;
            this.lblAunselect.Click += new System.EventHandler(this.LblAunselect_Click);
            // 
            // rbtD
            // 
            this.rbtD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.rbtD.Location = new System.Drawing.Point(141, 282);
            this.rbtD.Name = "rbtD";
            this.rbtD.Size = new System.Drawing.Size(20, 20);
            this.rbtD.TabIndex = 28;
            this.rbtD.Text = "D";
            this.rbtD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtB
            // 
            this.rbtB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.rbtB.Location = new System.Drawing.Point(141, 206);
            this.rbtB.Name = "rbtB";
            this.rbtB.Size = new System.Drawing.Size(20, 20);
            this.rbtB.TabIndex = 27;
            this.rbtB.Text = "B";
            this.rbtB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtC
            // 
            this.rbtC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.rbtC.Location = new System.Drawing.Point(141, 246);
            this.rbtC.Name = "rbtC";
            this.rbtC.Size = new System.Drawing.Size(20, 20);
            this.rbtC.TabIndex = 26;
            this.rbtC.Text = "C";
            this.rbtC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtA
            // 
            this.rbtA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.rbtA.Location = new System.Drawing.Point(141, 167);
            this.rbtA.Name = "rbtA";
            this.rbtA.Size = new System.Drawing.Size(20, 20);
            this.rbtA.TabIndex = 25;
            this.rbtA.Text = "A";
            this.rbtA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 10.5F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(419, 470);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 30);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(1022, 674);
            this.shapeContainer2.TabIndex = 16;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.Black;
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.rectangleShape1.FillColor = System.Drawing.Color.Gray;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.White;
            this.rectangleShape1.Location = new System.Drawing.Point(109, 112);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.rectangleShape1.Size = new System.Drawing.Size(25, 25);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pnlExamResult
            // 
            this.pnlExamResult.Controls.Add(this.lblCorrectCount);
            this.pnlExamResult.Controls.Add(this.lblFragTwo);
            this.pnlExamResult.Controls.Add(this.lblGetScore);
            this.pnlExamResult.Controls.Add(this.lblFragOne);
            this.pnlExamResult.Controls.Add(this.lblViewDetail);
            this.pnlExamResult.Controls.Add(this.lblth);
            this.pnlExamResult.Controls.Add(this.shapeContainer1);
            this.pnlExamResult.Location = new System.Drawing.Point(2, 36);
            this.pnlExamResult.Name = "pnlExamResult";
            this.pnlExamResult.Size = new System.Drawing.Size(1022, 342);
            this.pnlExamResult.TabIndex = 15;
            this.pnlExamResult.Visible = false;
            // 
            // lblCorrectCount
            // 
            this.lblCorrectCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorrectCount.AutoSize = true;
            this.lblCorrectCount.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblCorrectCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblCorrectCount.Location = new System.Drawing.Point(634, 177);
            this.lblCorrectCount.Name = "lblCorrectCount";
            this.lblCorrectCount.Size = new System.Drawing.Size(20, 21);
            this.lblCorrectCount.TabIndex = 4;
            this.lblCorrectCount.Text = "0";
            this.lblCorrectCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFragTwo
            // 
            this.lblFragTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFragTwo.AutoSize = true;
            this.lblFragTwo.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblFragTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblFragTwo.Location = new System.Drawing.Point(457, 176);
            this.lblFragTwo.Name = "lblFragTwo";
            this.lblFragTwo.Size = new System.Drawing.Size(140, 21);
            this.lblFragTwo.TabIndex = 3;
            this.lblFragTwo.Text = "points, you got";
            this.lblFragTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGetScore
            // 
            this.lblGetScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGetScore.AutoSize = true;
            this.lblGetScore.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblGetScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblGetScore.Location = new System.Drawing.Point(399, 177);
            this.lblGetScore.Name = "lblGetScore";
            this.lblGetScore.Size = new System.Drawing.Size(45, 21);
            this.lblGetScore.TabIndex = 2;
            this.lblGetScore.Text = "100 ";
            this.lblGetScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFragOne
            // 
            this.lblFragOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFragOne.AutoSize = true;
            this.lblFragOne.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblFragOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblFragOne.Location = new System.Drawing.Point(256, 176);
            this.lblFragOne.Name = "lblFragOne";
            this.lblFragOne.Size = new System.Drawing.Size(131, 21);
            this.lblFragOne.TabIndex = 1;
            this.lblFragOne.Text = "Your score is ";
            // 
            // lblViewDetail
            // 
            this.lblViewDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblViewDetail.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblViewDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblViewDetail.Location = new System.Drawing.Point(419, 257);
            this.lblViewDetail.Name = "lblViewDetail";
            this.lblViewDetail.Size = new System.Drawing.Size(230, 38);
            this.lblViewDetail.TabIndex = 0;
            this.lblViewDetail.Text = "View the exam results detail";
            this.lblViewDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblViewDetail.Click += new System.EventHandler(this.LblViewDetail_Click);
            // 
            // lblth
            // 
            this.lblth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblth.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblth.Location = new System.Drawing.Point(661, 176);
            this.lblth.Name = "lblth";
            this.lblth.Size = new System.Drawing.Size(197, 21);
            this.lblth.TabIndex = 5;
            this.lblth.Text = "questions in this test.";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rt});
            this.shapeContainer1.Size = new System.Drawing.Size(1022, 342);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // rt
            // 
            this.rt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.rt.CornerRadius = 3;
            this.rt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rt.Location = new System.Drawing.Point(410, 250);
            this.rt.Name = "rt";
            this.rt.SelectionColor = System.Drawing.Color.White;
            this.rt.Size = new System.Drawing.Size(245, 50);
            this.rt.Click += new System.EventHandler(this.LblViewDetail_Click);
            // 
            // pnlAutoResult
            // 
            this.pnlAutoResult.Controls.Add(this.lblAtuoTitle);
            this.pnlAutoResult.Controls.Add(this.lbltest);
            this.pnlAutoResult.Controls.Add(this.lblAutoCorrectNum);
            this.pnlAutoResult.Controls.Add(this.lblPoint);
            this.pnlAutoResult.Controls.Add(this.lblAutoGetScore);
            this.pnlAutoResult.Controls.Add(this.lblYour);
            this.pnlAutoResult.Controls.Add(this.lblAutoSub);
            this.pnlAutoResult.Controls.Add(this.shapeContainer3);
            this.pnlAutoResult.Location = new System.Drawing.Point(6, 44);
            this.pnlAutoResult.Name = "pnlAutoResult";
            this.pnlAutoResult.Size = new System.Drawing.Size(1022, 342);
            this.pnlAutoResult.TabIndex = 16;
            this.pnlAutoResult.Visible = false;
            // 
            // lblAtuoTitle
            // 
            this.lblAtuoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAtuoTitle.AutoSize = true;
            this.lblAtuoTitle.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblAtuoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblAtuoTitle.Location = new System.Drawing.Point(277, 125);
            this.lblAtuoTitle.Name = "lblAtuoTitle";
            this.lblAtuoTitle.Size = new System.Drawing.Size(605, 21);
            this.lblAtuoTitle.TabIndex = 6;
            this.lblAtuoTitle.Text = "Your time is up, the system has automatically submitted to the test! ";
            this.lblAtuoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltest
            // 
            this.lbltest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltest.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lbltest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lbltest.Location = new System.Drawing.Point(674, 161);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(197, 21);
            this.lbltest.TabIndex = 5;
            this.lbltest.Text = "questions in this test.";
            // 
            // lblAutoCorrectNum
            // 
            this.lblAutoCorrectNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutoCorrectNum.AutoSize = true;
            this.lblAutoCorrectNum.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblAutoCorrectNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblAutoCorrectNum.Location = new System.Drawing.Point(644, 162);
            this.lblAutoCorrectNum.Name = "lblAutoCorrectNum";
            this.lblAutoCorrectNum.Size = new System.Drawing.Size(20, 21);
            this.lblAutoCorrectNum.TabIndex = 4;
            this.lblAutoCorrectNum.Text = "0";
            this.lblAutoCorrectNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPoint
            // 
            this.lblPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblPoint.Location = new System.Drawing.Point(466, 160);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(140, 21);
            this.lblPoint.TabIndex = 3;
            this.lblPoint.Text = "points, you got";
            this.lblPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAutoGetScore
            // 
            this.lblAutoGetScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutoGetScore.AutoSize = true;
            this.lblAutoGetScore.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblAutoGetScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblAutoGetScore.Location = new System.Drawing.Point(424, 161);
            this.lblAutoGetScore.Name = "lblAutoGetScore";
            this.lblAutoGetScore.Size = new System.Drawing.Size(25, 21);
            this.lblAutoGetScore.TabIndex = 2;
            this.lblAutoGetScore.Text = "0 ";
            this.lblAutoGetScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYour
            // 
            this.lblYour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYour.AutoSize = true;
            this.lblYour.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblYour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblYour.Location = new System.Drawing.Point(277, 161);
            this.lblYour.Name = "lblYour";
            this.lblYour.Size = new System.Drawing.Size(131, 21);
            this.lblYour.TabIndex = 1;
            this.lblYour.Text = "Your score is ";
            // 
            // lblAutoSub
            // 
            this.lblAutoSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAutoSub.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblAutoSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblAutoSub.Location = new System.Drawing.Point(413, 239);
            this.lblAutoSub.Name = "lblAutoSub";
            this.lblAutoSub.Size = new System.Drawing.Size(235, 35);
            this.lblAutoSub.TabIndex = 0;
            this.lblAutoSub.Text = "View the exam results detail";
            this.lblAutoSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAutoSub.Click += new System.EventHandler(this.LblViewDetail_Click);
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2});
            this.shapeContainer3.Size = new System.Drawing.Size(1022, 342);
            this.shapeContainer3.TabIndex = 7;
            this.shapeContainer3.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.rectangleShape2.CornerRadius = 3;
            this.rectangleShape2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape2.Location = new System.Drawing.Point(406, 230);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.SelectionColor = System.Drawing.Color.White;
            this.rectangleShape2.Size = new System.Drawing.Size(245, 50);
            this.rectangleShape2.Click += new System.EventHandler(this.LblViewDetail_Click);
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.White;
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(1024, 30);
            this.titleBar1.TabIndex = 17;
            // 
            // FormTakeExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.titleBar1);
            this.Controls.Add(this.pnlMainLayout);
            this.Controls.Add(this.pnlAutoResult);
            this.Controls.Add(this.pnlExamResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTakeExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTakeExam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTakeExam_FormClosed);
            this.Load += new System.EventHandler(this.FormTakeExam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMainLayout.ResumeLayout(false);
            this.pnlMainLayout.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlExamResult.ResumeLayout(false);
            this.pnlExamResult.PerformLayout();
            this.pnlAutoResult.ResumeLayout(false);
            this.pnlAutoResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimeTitle;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblfragmentone;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Label lblQuesNum;
        private System.Windows.Forms.Label lblQuesTitle;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblAnswerA;
        private System.Windows.Forms.Label lblAnswerB;
        private System.Windows.Forms.Label lblAnswerC;
        private System.Windows.Forms.Label lblAnswerD;
        private System.Windows.Forms.Panel pnlMainLayout;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel pnlExamResult;
        private System.Windows.Forms.Label lblth;
        private System.Windows.Forms.Label lblCorrectCount;
        private System.Windows.Forms.Label lblFragTwo;
        private System.Windows.Forms.Label lblGetScore;
        private System.Windows.Forms.Label lblFragOne;
        private System.Windows.Forms.Label lblViewDetail;
        private System.Windows.Forms.Label lblfragmenttwo;
        private System.Windows.Forms.Label lblEachPoint;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Panel pnlAutoResult;
        private System.Windows.Forms.Label lblAtuoTitle;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.Label lblAutoCorrectNum;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblAutoGetScore;
        private System.Windows.Forms.Label lblYour;
        private System.Windows.Forms.Label lblAutoSub;
        private System.Windows.Forms.Label lblDunselect;
        private System.Windows.Forms.Label lblCunselect;
        private System.Windows.Forms.Label lblBunselect;
        private System.Windows.Forms.Label lblCSelect;
        private System.Windows.Forms.Label lblDSelect;
        private System.Windows.Forms.Label lblBSelect;
        private System.Windows.Forms.Label lblAunselect;
        private System.Windows.Forms.Label lblASelect;
        private System.Windows.Forms.Label rbtD;
        private System.Windows.Forms.Label rbtB;
        private System.Windows.Forms.Label rbtC;
        private System.Windows.Forms.Label rbtA;
        private System.Windows.Forms.Panel panel2;
        private Custom.TitleBar titleBar1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rt;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;

    }
}