namespace OesUI.Custom
{
    partial class CustomTimer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.VerificationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblShowTime
            // 
            this.lblShowTime.BackColor = System.Drawing.Color.Transparent;
            this.lblShowTime.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblShowTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.lblShowTime.Location = new System.Drawing.Point(0, 0);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(50, 30);
            this.lblShowTime.TabIndex = 0;
            this.lblShowTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VerificationTimer
            // 
            this.VerificationTimer.Interval = 1000;
            this.VerificationTimer.Tick += new System.EventHandler(this.VerificationTimer_Tick);
            // 
            // CustomTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblShowTime);
            this.Name = "CustomTimer";
            this.Size = new System.Drawing.Size(50, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.Timer VerificationTimer;
    }
}
