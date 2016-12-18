namespace OesUI
{
    partial class ExamDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamDescription));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEffective = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.TimerShow = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.StartTest = new System.Windows.Forms.Button();
            this.lblEffectiveTimeValue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblDurationvalue = new System.Windows.Forms.Label();
            this.lblQuestionCountValue = new System.Windows.Forms.Label();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.lblEndTimeValue = new System.Windows.Forms.Label();
            this.lblTotalScoreValue = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblstart = new System.Windows.Forms.Label();
            this.lblHintClose = new System.Windows.Forms.Label();
            this.lblHintMessage = new System.Windows.Forms.Label();
            this.pnlHint = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.titleBar1 = new OesUI.Custom.TitleBar();
            this.pnlHint.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblTitle.Location = new System.Drawing.Point(390, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "The Exam Description";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.lblName.Location = new System.Drawing.Point(75, 156);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblEffective
            // 
            this.lblEffective.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffective.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.lblEffective.Location = new System.Drawing.Point(75, 182);
            this.lblEffective.Name = "lblEffective";
            this.lblEffective.Size = new System.Drawing.Size(86, 15);
            this.lblEffective.TabIndex = 2;
            this.lblEffective.Text = "Effective Time:";
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.lblDuration.Location = new System.Drawing.Point(74, 208);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(57, 15);
            this.lblDuration.TabIndex = 3;
            this.lblDuration.Text = "Duration:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.lblQuestion.Location = new System.Drawing.Point(74, 236);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(67, 15);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "Questions:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.lblId.Location = new System.Drawing.Point(359, 156);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 15);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "ID:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.lblEndTime.Location = new System.Drawing.Point(359, 182);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(63, 15);
            this.lblEndTime.TabIndex = 6;
            this.lblEndTime.Text = "End Time:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.lblTotal.Location = new System.Drawing.Point(359, 208);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 15);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // TimerShow
            // 
            this.TimerShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerShow.AutoSize = true;
            this.TimerShow.BackColor = System.Drawing.Color.White;
            this.TimerShow.Font = new System.Drawing.Font("Arial", 22.5F, System.Drawing.FontStyle.Bold);
            this.TimerShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.TimerShow.Location = new System.Drawing.Point(723, 168);
            this.TimerShow.Name = "TimerShow";
            this.TimerShow.Size = new System.Drawing.Size(137, 35);
            this.TimerShow.TabIndex = 8;
            this.TimerShow.Text = "00:00:00";
            this.TimerShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.5F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label8.Location = new System.Drawing.Point(75, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Notice:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.5F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label9.Location = new System.Drawing.Point(78, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "1) Only one choice supported.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.5F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label10.Location = new System.Drawing.Point(78, 409);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "2) The exam has time limitation.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.5F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label11.Location = new System.Drawing.Point(78, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(301, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "3) You should only see one question at a time.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.5F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label12.Location = new System.Drawing.Point(78, 462);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(376, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "4) Once you submit, you won\'t see the answered question.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.5F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label13.Location = new System.Drawing.Point(78, 490);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(440, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "5) When the exam exceeds time limitation, it will submit automatically.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.5F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label14.Location = new System.Drawing.Point(78, 513);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(627, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "6) if you exists a exam which isn\'t submitted yet, you can continue the exam befo" +
                "re the end of time.";
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Return.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Return.FlatAppearance.BorderSize = 0;
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return.Font = new System.Drawing.Font("Arial", 10.5F);
            this.Return.ForeColor = System.Drawing.Color.White;
            this.Return.Location = new System.Drawing.Point(296, 618);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(150, 30);
            this.Return.TabIndex = 16;
            this.Return.TabStop = false;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = false;
            // 
            // StartTest
            // 
            this.StartTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.StartTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartTest.Font = new System.Drawing.Font("Arial", 10.5F);
            this.StartTest.ForeColor = System.Drawing.Color.White;
            this.StartTest.Location = new System.Drawing.Point(513, 618);
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(150, 30);
            this.StartTest.TabIndex = 17;
            this.StartTest.TabStop = false;
            this.StartTest.Text = "Start Testing";
            this.StartTest.UseVisualStyleBackColor = false;
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // lblEffectiveTimeValue
            // 
            this.lblEffectiveTimeValue.AutoSize = true;
            this.lblEffectiveTimeValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffectiveTimeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.lblEffectiveTimeValue.Location = new System.Drawing.Point(157, 182);
            this.lblEffectiveTimeValue.Name = "lblEffectiveTimeValue";
            this.lblEffectiveTimeValue.Size = new System.Drawing.Size(86, 15);
            this.lblEffectiveTimeValue.TabIndex = 18;
            this.lblEffectiveTimeValue.Text = "Effective Time:";
            this.lblEffectiveTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.lblNameValue.Location = new System.Drawing.Point(114, 156);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(44, 15);
            this.lblNameValue.TabIndex = 19;
            this.lblNameValue.Text = "Name:";
            this.lblNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDurationvalue
            // 
            this.lblDurationvalue.AutoSize = true;
            this.lblDurationvalue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurationvalue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.lblDurationvalue.Location = new System.Drawing.Point(129, 208);
            this.lblDurationvalue.Name = "lblDurationvalue";
            this.lblDurationvalue.Size = new System.Drawing.Size(57, 15);
            this.lblDurationvalue.TabIndex = 20;
            this.lblDurationvalue.Text = "Duration:";
            this.lblDurationvalue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuestionCountValue
            // 
            this.lblQuestionCountValue.AutoSize = true;
            this.lblQuestionCountValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionCountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.lblQuestionCountValue.Location = new System.Drawing.Point(136, 236);
            this.lblQuestionCountValue.Name = "lblQuestionCountValue";
            this.lblQuestionCountValue.Size = new System.Drawing.Size(67, 15);
            this.lblQuestionCountValue.TabIndex = 21;
            this.lblQuestionCountValue.Text = "Questions:";
            this.lblQuestionCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdValue
            // 
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.lblIdValue.Location = new System.Drawing.Point(391, 156);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(22, 15);
            this.lblIdValue.TabIndex = 22;
            this.lblIdValue.Text = "ID:";
            this.lblIdValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEndTimeValue
            // 
            this.lblEndTimeValue.AutoSize = true;
            this.lblEndTimeValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTimeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.lblEndTimeValue.Location = new System.Drawing.Point(425, 182);
            this.lblEndTimeValue.Name = "lblEndTimeValue";
            this.lblEndTimeValue.Size = new System.Drawing.Size(63, 15);
            this.lblEndTimeValue.TabIndex = 23;
            this.lblEndTimeValue.Text = "End Time:";
            this.lblEndTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalScoreValue
            // 
            this.lblTotalScoreValue.AutoSize = true;
            this.lblTotalScoreValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScoreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.lblTotalScoreValue.Location = new System.Drawing.Point(391, 208);
            this.lblTotalScoreValue.Name = "lblTotalScoreValue";
            this.lblTotalScoreValue.Size = new System.Drawing.Size(37, 15);
            this.lblTotalScoreValue.TabIndex = 24;
            this.lblTotalScoreValue.Text = "Total:";
            this.lblTotalScoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1024, 768);
            this.shapeContainer1.TabIndex = 25;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.Location = new System.Drawing.Point(583, 161);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(384, 50);
            // 
            // lblstart
            // 
            this.lblstart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblstart.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblstart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblstart.Location = new System.Drawing.Point(590, 165);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(118, 45);
            this.lblstart.TabIndex = 26;
            this.lblstart.Text = "Start The Exam";
            this.lblstart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHintClose
            // 
            this.lblHintClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHintClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHintClose.Image = ((System.Drawing.Image)(resources.GetObject("lblHintClose.Image")));
            this.lblHintClose.Location = new System.Drawing.Point(365, 10);
            this.lblHintClose.Name = "lblHintClose";
            this.lblHintClose.Size = new System.Drawing.Size(20, 20);
            this.lblHintClose.TabIndex = 28;
            this.lblHintClose.Click += new System.EventHandler(this.LblHintClose_Click);
            // 
            // lblHintMessage
            // 
            this.lblHintMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHintMessage.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblHintMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblHintMessage.Location = new System.Drawing.Point(0, 52);
            this.lblHintMessage.Name = "lblHintMessage";
            this.lblHintMessage.Size = new System.Drawing.Size(400, 16);
            this.lblHintMessage.TabIndex = 30;
            this.lblHintMessage.Text = "The exam hasn\'t gotton time!";
            this.lblHintMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHint
            // 
            this.pnlHint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHint.Controls.Add(this.lblHintMessage);
            this.pnlHint.Controls.Add(this.btnConfirm);
            this.pnlHint.Controls.Add(this.lblHintClose);
            this.pnlHint.Location = new System.Drawing.Point(287, 231);
            this.pnlHint.Name = "pnlHint";
            this.pnlHint.Size = new System.Drawing.Size(400, 200);
            this.pnlHint.TabIndex = 31;
            this.pnlHint.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(157, 115);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(80, 30);
            this.btnConfirm.TabIndex = 31;
            this.btnConfirm.TabStop = false;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.White;
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(1024, 30);
            this.titleBar1.TabIndex = 32;
            // 
            // ExamDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Return;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pnlHint);
            this.Controls.Add(this.titleBar1);
            this.Controls.Add(this.lblstart);
            this.Controls.Add(this.lblTotalScoreValue);
            this.Controls.Add(this.lblEndTimeValue);
            this.Controls.Add(this.lblIdValue);
            this.Controls.Add(this.lblQuestionCountValue);
            this.Controls.Add(this.lblDurationvalue);
            this.Controls.Add(this.lblNameValue);
            this.Controls.Add(this.lblEffectiveTimeValue);
            this.Controls.Add(this.StartTest);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TimerShow);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblEffective);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExamDescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamDescription";
            this.Load += new System.EventHandler(this.ExamDescription_Load);
            this.pnlHint.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEffective;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label TimerShow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button StartTest;
        private System.Windows.Forms.Label lblEffectiveTimeValue;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblDurationvalue;
        private System.Windows.Forms.Label lblQuestionCountValue;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label lblEndTimeValue;
        private System.Windows.Forms.Label lblTotalScoreValue;
        private System.Windows.Forms.Timer timer1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Label lblHintClose;
        private System.Windows.Forms.Label lblHintMessage;
        private System.Windows.Forms.Panel pnlHint;
        private System.Windows.Forms.Button btnConfirm;
        private Custom.TitleBar titleBar1;
    }
}