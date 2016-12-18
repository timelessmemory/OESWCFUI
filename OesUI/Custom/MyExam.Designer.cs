namespace OesUI.Custom
{
    partial class MyExam
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
            this.lblUnfinishedExam = new System.Windows.Forms.Label();
            this.lblFinishedExam = new System.Windows.Forms.Label();
            this.lblAll = new System.Windows.Forms.Label();
            this.lblLien = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.pnlPagination = new System.Windows.Forms.FlowLayoutPanel();
            this.AllExam = new OesUI.Custom.ExamList();
            this.SuspendLayout();
            // 
            // lblUnfinishedExam
            // 
            this.lblUnfinishedExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnfinishedExam.BackColor = System.Drawing.Color.White;
            this.lblUnfinishedExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUnfinishedExam.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblUnfinishedExam.ForeColor = System.Drawing.Color.Black;
            this.lblUnfinishedExam.Location = new System.Drawing.Point(573, 30);
            this.lblUnfinishedExam.Name = "lblUnfinishedExam";
            this.lblUnfinishedExam.Size = new System.Drawing.Size(100, 30);
            this.lblUnfinishedExam.TabIndex = 7;
            this.lblUnfinishedExam.Text = "Unfinished";
            this.lblUnfinishedExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUnfinishedExam.Click += new System.EventHandler(this.LblUnfinishedExam_Click);
            // 
            // lblFinishedExam
            // 
            this.lblFinishedExam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFinishedExam.BackColor = System.Drawing.Color.White;
            this.lblFinishedExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFinishedExam.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblFinishedExam.ForeColor = System.Drawing.Color.Black;
            this.lblFinishedExam.Location = new System.Drawing.Point(428, 30);
            this.lblFinishedExam.Name = "lblFinishedExam";
            this.lblFinishedExam.Size = new System.Drawing.Size(100, 30);
            this.lblFinishedExam.TabIndex = 6;
            this.lblFinishedExam.Text = "Finished";
            this.lblFinishedExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinishedExam.Click += new System.EventHandler(this.LblFinishedExam_Click);
            // 
            // lblAll
            // 
            this.lblAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAll.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblAll.ForeColor = System.Drawing.Color.White;
            this.lblAll.Location = new System.Drawing.Point(271, 30);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(100, 30);
            this.lblAll.TabIndex = 5;
            this.lblAll.Text = "All";
            this.lblAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAll.Click += new System.EventHandler(this.LblAll_Click);
            // 
            // lblLien
            // 
            this.lblLien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblLien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblLien.Location = new System.Drawing.Point(0, 70);
            this.lblLien.Name = "lblLien";
            this.lblLien.Size = new System.Drawing.Size(980, 1);
            this.lblLien.TabIndex = 15;
            this.lblLien.Text = "label1";
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblLine.ForeColor = System.Drawing.Color.White;
            this.lblLine.Location = new System.Drawing.Point(0, 110);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(980, 1);
            this.lblLine.TabIndex = 16;
            this.lblLine.Text = "label2";
            // 
            // pnlPagination
            // 
            this.pnlPagination.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlPagination.AutoSize = true;
            this.pnlPagination.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPagination.Location = new System.Drawing.Point(331, 581);
            this.pnlPagination.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlPagination.Size = new System.Drawing.Size(604, 54);
            this.pnlPagination.TabIndex = 21;
            // 
            // AllExam
            // 
            this.AllExam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AllExam.BackColor = System.Drawing.Color.White;
            this.AllExam.Location = new System.Drawing.Point(0, 70);
            this.AllExam.Name = "AllExam";
            this.AllExam.Size = new System.Drawing.Size(980, 492);
            this.AllExam.TabIndex = 8;
            this.AllExam.Load += new System.EventHandler(this.AllExam_Load);
            // 
            // MyExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlPagination);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblLien);
            this.Controls.Add(this.lblUnfinishedExam);
            this.Controls.Add(this.lblFinishedExam);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.AllExam);
            this.Name = "MyExam";
            this.Size = new System.Drawing.Size(980, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ExamList GetAllExam()
        {
            return this.AllExam;
        }

        public System.Windows.Forms.Label GetFinishedLabel()
        {
            return this.lblFinishedExam;
        }

        public System.Windows.Forms.Label GetUnFinishedLabel()
        {
            return this.lblUnfinishedExam;
        }

        public System.Windows.Forms.Label GetAllLabel()
        {
            return this.lblAll;
        }

        private System.Windows.Forms.Label lblUnfinishedExam;
        private System.Windows.Forms.Label lblFinishedExam;
        private System.Windows.Forms.Label lblAll;
        private ExamList AllExam;
        private System.Windows.Forms.Label lblLien;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.FlowLayoutPanel pnlPagination;
    }
}
