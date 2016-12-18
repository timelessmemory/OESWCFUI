namespace OesUI
{
    partial class txtfrom
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
            this.customTimer1 = new OesUI.Custom.CustomTimer();
            this.titleBar1 = new OesUI.Custom.TitleBar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customTimer1
            // 
            this.customTimer1.Location = new System.Drawing.Point(291, 99);
            this.customTimer1.Name = "customTimer1";
            this.customTimer1.Size = new System.Drawing.Size(50, 30);
            this.customTimer1.TabIndex = 4;
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.White;
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(795, 30);
            this.titleBar1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customTimer1);
            this.Controls.Add(this.titleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "txtfrom";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Custom.TitleBar titleBar1;
        private Custom.CustomTimer customTimer1;
        private System.Windows.Forms.Button button1;

    }
}