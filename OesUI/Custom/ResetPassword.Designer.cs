namespace OesUI.Custom
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.lblClose = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblVerification = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblEmailDiv = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblUsernameDiv = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblPasswordConfirm = new System.Windows.Forms.Label();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.customTimer = new OesUI.Custom.CustomTimer();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(466, 11);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 20);
            this.lblClose.TabIndex = 20;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMessage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(160, 49);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(300, 20);
            this.lblErrorMessage.TabIndex = 19;
            this.lblErrorMessage.Text = "Verification code is required!";
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMessage.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(223, 4);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 35);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Reset Pasword";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(39, 130);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 35);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVerification
            // 
            this.lblVerification.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblVerification.ForeColor = System.Drawing.Color.White;
            this.lblVerification.Location = new System.Drawing.Point(26, 78);
            this.lblVerification.Margin = new System.Windows.Forms.Padding(0);
            this.lblVerification.Name = "lblVerification";
            this.lblVerification.Size = new System.Drawing.Size(113, 35);
            this.lblVerification.TabIndex = 16;
            this.lblVerification.Text = "Verification code";
            this.lblVerification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.CausesValidation = false;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.txtPassword.Location = new System.Drawing.Point(180, 139);
            this.txtPassword.MaxLength = 15;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(232, 17);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Enter += new System.EventHandler(this.txtCode_Enter);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 15F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(169, 234);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(280, 34);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.CausesValidation = false;
            this.txtCode.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.txtCode.Location = new System.Drawing.Point(180, 87);
            this.txtCode.MaxLength = 9;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(232, 17);
            this.txtCode.TabIndex = 5;
            this.txtCode.Enter += new System.EventHandler(this.txtCode_Enter);
            this.txtCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtCode_Validating);
            // 
            // lblEmailDiv
            // 
            this.lblEmailDiv.BackColor = System.Drawing.Color.White;
            this.lblEmailDiv.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.lblEmailDiv.CornerRadius = 5;
            this.lblEmailDiv.FillColor = System.Drawing.Color.White;
            this.lblEmailDiv.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.lblEmailDiv.Location = new System.Drawing.Point(160, 130);
            this.lblEmailDiv.Name = "lblEmailDiv";
            this.lblEmailDiv.SelectionColor = System.Drawing.SystemColors.ScrollBar;
            this.lblEmailDiv.Size = new System.Drawing.Size(300, 35);
            // 
            // lblUsernameDiv
            // 
            this.lblUsernameDiv.BackColor = System.Drawing.Color.White;
            this.lblUsernameDiv.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.lblUsernameDiv.CornerRadius = 5;
            this.lblUsernameDiv.FillColor = System.Drawing.Color.White;
            this.lblUsernameDiv.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.lblUsernameDiv.Location = new System.Drawing.Point(160, 77);
            this.lblUsernameDiv.Name = "lblUsernameDiv";
            this.lblUsernameDiv.SelectionColor = System.Drawing.SystemColors.ScrollBar;
            this.lblUsernameDiv.Size = new System.Drawing.Size(300, 35);
            // 
            // rectangleShape
            // 
            this.rectangleShape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.rectangleShape.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.rectangleShape.CornerRadius = 5;
            this.rectangleShape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.rectangleShape.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.rectangleShape.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape.Location = new System.Drawing.Point(160, 233);
            this.rectangleShape.Name = "rectangleShape";
            this.rectangleShape.Size = new System.Drawing.Size(300, 35);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.rectangleShape,
            this.lblUsernameDiv,
            this.lblEmailDiv});
            this.shapeContainer1.Size = new System.Drawing.Size(500, 300);
            this.shapeContainer1.TabIndex = 21;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.White;
            this.rectangleShape1.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.rectangleShape1.CornerRadius = 5;
            this.rectangleShape1.FillColor = System.Drawing.Color.White;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(160, 185);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.SelectionColor = System.Drawing.SystemColors.ScrollBar;
            this.rectangleShape1.Size = new System.Drawing.Size(300, 35);
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblPasswordConfirm.ForeColor = System.Drawing.Color.White;
            this.lblPasswordConfirm.Location = new System.Drawing.Point(10, 184);
            this.lblPasswordConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(129, 35);
            this.lblPasswordConfirm.TabIndex = 23;
            this.lblPasswordConfirm.Text = "Password Confirm";
            this.lblPasswordConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.BackColor = System.Drawing.Color.White;
            this.txtPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordConfirm.CausesValidation = false;
            this.txtPasswordConfirm.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.txtPasswordConfirm.Location = new System.Drawing.Point(180, 194);
            this.txtPasswordConfirm.MaxLength = 15;
            this.txtPasswordConfirm.Multiline = true;
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '●';
            this.txtPasswordConfirm.Size = new System.Drawing.Size(232, 17);
            this.txtPasswordConfirm.TabIndex = 7;
            this.txtPasswordConfirm.Enter += new System.EventHandler(this.txtCode_Enter);
            this.txtPasswordConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordConfirm_Validating);
            // 
            // customTimer
            // 
            this.customTimer.BackColor = System.Drawing.Color.Transparent;
            this.customTimer.Location = new System.Drawing.Point(28, 10);
            this.customTimer.Name = "customTimer";
            this.customTimer.Size = new System.Drawing.Size(50, 30);
            this.customTimer.TabIndex = 24;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.customTimer);
            this.Controls.Add(this.lblPasswordConfirm);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblVerification);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ResetPassword";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResetPassword_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResetPassword_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblVerification;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label btnConfirm;
        private System.Windows.Forms.TextBox txtCode;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape lblEmailDiv;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape lblUsernameDiv;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label lblPasswordConfirm;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private CustomTimer customTimer;
    }
}