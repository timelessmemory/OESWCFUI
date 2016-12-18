namespace OesUI.Custom
{
    partial class FillUserInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FillUserInfoForm));
            this.lblClose = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsernameDiv = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblEmailDiv = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(468, 11);
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
            this.lblErrorMessage.Location = new System.Drawing.Point(145, 66);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(300, 20);
            this.lblErrorMessage.TabIndex = 19;
            this.lblErrorMessage.Text = "Username is required!";
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMessage.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(209, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 35);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Forget Pasword";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(20, 162);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 35);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(20, 94);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(100, 35);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "Username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.CausesValidation = false;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.txtEmail.Location = new System.Drawing.Point(157, 172);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 17);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Font = new System.Drawing.Font("Arial", 15F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(155, 228);
            this.btnFind.Margin = new System.Windows.Forms.Padding(0);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(280, 34);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Send";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.CausesValidation = false;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.txtUsername.Location = new System.Drawing.Point(157, 104);
            this.txtUsername.MaxLength = 30;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(232, 17);
            this.txtUsername.TabIndex = 14;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lblUsernameDiv
            // 
            this.lblUsernameDiv.BackColor = System.Drawing.Color.White;
            this.lblUsernameDiv.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.lblUsernameDiv.CornerRadius = 5;
            this.lblUsernameDiv.FillColor = System.Drawing.Color.White;
            this.lblUsernameDiv.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.lblUsernameDiv.Location = new System.Drawing.Point(145, 92);
            this.lblUsernameDiv.Name = "lblUsernameDiv";
            this.lblUsernameDiv.SelectionColor = System.Drawing.SystemColors.ScrollBar;
            this.lblUsernameDiv.Size = new System.Drawing.Size(300, 35);
            // 
            // lblEmailDiv
            // 
            this.lblEmailDiv.BackColor = System.Drawing.Color.White;
            this.lblEmailDiv.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.lblEmailDiv.CornerRadius = 5;
            this.lblEmailDiv.FillColor = System.Drawing.Color.White;
            this.lblEmailDiv.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.lblEmailDiv.Location = new System.Drawing.Point(145, 160);
            this.lblEmailDiv.Name = "lblEmailDiv";
            this.lblEmailDiv.SelectionColor = System.Drawing.SystemColors.ScrollBar;
            this.lblEmailDiv.Size = new System.Drawing.Size(300, 35);
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
            this.rectangleShape.Location = new System.Drawing.Point(145, 227);
            this.rectangleShape.Name = "rectangleShape";
            this.rectangleShape.Size = new System.Drawing.Size(300, 35);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape,
            this.lblEmailDiv,
            this.lblUsernameDiv});
            this.shapeContainer1.Size = new System.Drawing.Size(500, 300);
            this.shapeContainer1.TabIndex = 21;
            this.shapeContainer1.TabStop = false;
            // 
            // FillUserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FillUserInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FillUserInfoForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FillUserInfo_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FillUserInfoForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label btnFind;
        private System.Windows.Forms.TextBox txtUsername;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape lblUsernameDiv;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape lblEmailDiv;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}