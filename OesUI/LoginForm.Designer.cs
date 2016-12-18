namespace OesUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblSystemLogo = new System.Windows.Forms.Label();
            this.lblForgetPass = new System.Windows.Forms.Label();
            this.lblUserIcon = new System.Windows.Forms.Label();
            this.lblPasswordIcon = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblUsernameErrorMessage = new System.Windows.Forms.Label();
            this.lblPassErrorMessage = new System.Windows.Forms.Label();
            this.pcTitle = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblPasswordDiv = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblUsernameDiv = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnLogin = new System.Windows.Forms.Label();
            this.ckxRemember = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblUnselect = new System.Windows.Forms.Label();
            this.teacherExamManager1 = new OesUI.ExamService.TeacherExamManager();
            ((System.ComponentModel.ISupportInitialize)(this.pcTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherExamManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.CausesValidation = false;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.txtUsername.Location = new System.Drawing.Point(250, 180);
            this.txtUsername.MaxLength = 30;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(232, 17);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TabStop = false;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.UserName_Enter);
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.UserName_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.CausesValidation = false;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.txtPassword.Location = new System.Drawing.Point(250, 235);
            this.txtPassword.MaxLength = 15;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(232, 17);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.Password_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.Password_Validating);
            // 
            // lblSystemLogo
            // 
            this.lblSystemLogo.Image = ((System.Drawing.Image)(resources.GetObject("lblSystemLogo.Image")));
            this.lblSystemLogo.Location = new System.Drawing.Point(200, 80);
            this.lblSystemLogo.Name = "lblSystemLogo";
            this.lblSystemLogo.Size = new System.Drawing.Size(300, 40);
            this.lblSystemLogo.TabIndex = 1;
            // 
            // lblForgetPass
            // 
            this.lblForgetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgetPass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetPass.ForeColor = System.Drawing.Color.White;
            this.lblForgetPass.Location = new System.Drawing.Point(399, 335);
            this.lblForgetPass.Name = "lblForgetPass";
            this.lblForgetPass.Size = new System.Drawing.Size(107, 15);
            this.lblForgetPass.TabIndex = 5;
            this.lblForgetPass.Text = "Forget password?";
            this.lblForgetPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblForgetPass.Click += new System.EventHandler(this.lblForgetPass_Click);
            // 
            // lblUserIcon
            // 
            this.lblUserIcon.BackColor = System.Drawing.Color.White;
            this.lblUserIcon.ForeColor = System.Drawing.Color.White;
            this.lblUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("lblUserIcon.Image")));
            this.lblUserIcon.Location = new System.Drawing.Point(220, 178);
            this.lblUserIcon.Name = "lblUserIcon";
            this.lblUserIcon.Size = new System.Drawing.Size(20, 20);
            this.lblUserIcon.TabIndex = 6;
            // 
            // lblPasswordIcon
            // 
            this.lblPasswordIcon.BackColor = System.Drawing.Color.White;
            this.lblPasswordIcon.Image = ((System.Drawing.Image)(resources.GetObject("lblPasswordIcon.Image")));
            this.lblPasswordIcon.Location = new System.Drawing.Point(221, 233);
            this.lblPasswordIcon.Name = "lblPasswordIcon";
            this.lblPasswordIcon.Size = new System.Drawing.Size(20, 20);
            this.lblPasswordIcon.TabIndex = 7;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(203)))), ((int)(((byte)(155)))));
            this.lblErrorMessage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(199, 142);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(300, 20);
            this.lblErrorMessage.TabIndex = 1;
            this.lblErrorMessage.Text = "Username does\'t exist!";
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMessage.Visible = false;
            // 
            // lblUsernameErrorMessage
            // 
            this.lblUsernameErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblUsernameErrorMessage.Image")));
            this.lblUsernameErrorMessage.Location = new System.Drawing.Point(506, 178);
            this.lblUsernameErrorMessage.Name = "lblUsernameErrorMessage";
            this.lblUsernameErrorMessage.Size = new System.Drawing.Size(20, 20);
            this.lblUsernameErrorMessage.TabIndex = 11;
            this.lblUsernameErrorMessage.Visible = false;
            // 
            // lblPassErrorMessage
            // 
            this.lblPassErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblPassErrorMessage.Image")));
            this.lblPassErrorMessage.Location = new System.Drawing.Point(506, 235);
            this.lblPassErrorMessage.Name = "lblPassErrorMessage";
            this.lblPassErrorMessage.Size = new System.Drawing.Size(20, 20);
            this.lblPassErrorMessage.TabIndex = 12;
            this.lblPassErrorMessage.Visible = false;
            // 
            // pcTitle
            // 
            this.pcTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcTitle.BackgroundImage")));
            this.pcTitle.Image = ((System.Drawing.Image)(resources.GetObject("pcTitle.Image")));
            this.pcTitle.Location = new System.Drawing.Point(1, -1);
            this.pcTitle.Name = "pcTitle";
            this.pcTitle.Size = new System.Drawing.Size(700, 30);
            this.pcTitle.TabIndex = 13;
            this.pcTitle.TabStop = false;
            this.pcTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PcTitle_MouseDown);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.White;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(659, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(30, 20);
            this.lblClose.TabIndex = 14;
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.lblPasswordDiv,
            this.lblUsernameDiv});
            this.shapeContainer1.Size = new System.Drawing.Size(700, 500);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.rectangleShape1.CornerRadius = 5;
            this.rectangleShape1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(200, 280);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(300, 35);
            this.rectangleShape1.Click += new System.EventHandler(this.Login_Click);
            // 
            // lblPasswordDiv
            // 
            this.lblPasswordDiv.BackColor = System.Drawing.Color.White;
            this.lblPasswordDiv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblPasswordDiv.CornerRadius = 5;
            this.lblPasswordDiv.FillColor = System.Drawing.Color.White;
            this.lblPasswordDiv.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.lblPasswordDiv.Location = new System.Drawing.Point(200, 225);
            this.lblPasswordDiv.Name = "lblPasswordDiv";
            this.lblPasswordDiv.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblPasswordDiv.Size = new System.Drawing.Size(300, 35);
            // 
            // lblUsernameDiv
            // 
            this.lblUsernameDiv.BackColor = System.Drawing.Color.White;
            this.lblUsernameDiv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblUsernameDiv.CornerRadius = 5;
            this.lblUsernameDiv.FillColor = System.Drawing.Color.White;
            this.lblUsernameDiv.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.lblUsernameDiv.Location = new System.Drawing.Point(200, 170);
            this.lblUsernameDiv.Name = "lblUsernameDiv";
            this.lblUsernameDiv.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblUsernameDiv.Size = new System.Drawing.Size(300, 35);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 15F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(210, 281);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(280, 34);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.Login_Click);
            // 
            // ckxRemember
            // 
            this.ckxRemember.Font = new System.Drawing.Font("Arial", 9F);
            this.ckxRemember.ForeColor = System.Drawing.Color.White;
            this.ckxRemember.Location = new System.Drawing.Point(223, 335);
            this.ckxRemember.Name = "ckxRemember";
            this.ckxRemember.Size = new System.Drawing.Size(107, 15);
            this.ckxRemember.TabIndex = 1;
            this.ckxRemember.Text = "Remember me";
            this.ckxRemember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSelect
            // 
            this.lblSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSelect.Image = ((System.Drawing.Image)(resources.GetObject("lblSelect.Image")));
            this.lblSelect.Location = new System.Drawing.Point(200, 335);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(12, 12);
            this.lblSelect.TabIndex = 17;
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSelect.Click += new System.EventHandler(this.lblSelect_Click);
            // 
            // lblUnselect
            // 
            this.lblUnselect.BackColor = System.Drawing.Color.White;
            this.lblUnselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUnselect.Image = ((System.Drawing.Image)(resources.GetObject("lblUnselect.Image")));
            this.lblUnselect.Location = new System.Drawing.Point(200, 335);
            this.lblUnselect.Margin = new System.Windows.Forms.Padding(0);
            this.lblUnselect.Name = "lblUnselect";
            this.lblUnselect.Size = new System.Drawing.Size(12, 12);
            this.lblUnselect.TabIndex = 18;
            this.lblUnselect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUnselect.Visible = false;
            this.lblUnselect.Click += new System.EventHandler(this.lblUnselect_Click);
            // 
            // teacherExamManager1
            // 
            this.teacherExamManager1.DataSetName = "TeacherExamManager";
            this.teacherExamManager1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUnselect);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.ckxRemember);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.pcTitle);
            this.Controls.Add(this.lblPassErrorMessage);
            this.Controls.Add(this.lblUsernameErrorMessage);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPasswordIcon);
            this.Controls.Add(this.lblUserIcon);
            this.Controls.Add(this.lblForgetPass);
            this.Controls.Add(this.lblSystemLogo);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Augmemtum";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherExamManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPasswordIcon;
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.Label lblForgetPass;
        private System.Windows.Forms.Label lblSystemLogo;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblUsernameErrorMessage;
        private System.Windows.Forms.Label lblPassErrorMessage;
        private System.Windows.Forms.PictureBox pcTitle;
        private System.Windows.Forms.Label lblClose;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape lblPasswordDiv;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape lblUsernameDiv;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label btnLogin;
        private System.Windows.Forms.Label ckxRemember;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblUnselect;
        private ExamService.TeacherExamManager teacherExamManager1;
    }
}