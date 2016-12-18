using System.Windows.Forms;
namespace OesUI.Custom
{
    public partial class ExamList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblIDIncrease = new System.Windows.Forms.Label();
            this.lblIDdecrease = new System.Windows.Forms.Label();
            this.lblNameDecrease = new System.Windows.Forms.Label();
            this.lblNameIncrease = new System.Windows.Forms.Label();
            this.lblTimeIncrease = new System.Windows.Forms.Label();
            this.lblTimeDecrease = new System.Windows.Forms.Label();
            this.lblPassIncrease = new System.Windows.Forms.Label();
            this.lblPassDecrease = new System.Windows.Forms.Label();
            this.lblTotalIncrease = new System.Windows.Forms.Label();
            this.lblTotalDecrease = new System.Windows.Forms.Label();
            this.lblCriteriaIncre = new System.Windows.Forms.Label();
            this.lblCriteriaDecre = new System.Windows.Forms.Label();
            this.dgvExamList = new System.Windows.Forms.DataGridView();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.pnl = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.pnll = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.ppnl = new System.Windows.Forms.Panel();
            this.lblPass = new System.Windows.Forms.Label();
            this.pnel = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnell = new System.Windows.Forms.Panel();
            this.lblOperation = new System.Windows.Forms.Label();
            this.ppnel = new System.Windows.Forms.Panel();
            this.lblNo = new System.Windows.Forms.Label();
            this.panell = new System.Windows.Forms.Panel();
            this.lblDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamList)).BeginInit();
            this.tlp.SuspendLayout();
            this.pnl.SuspendLayout();
            this.panel.SuspendLayout();
            this.pnll.SuspendLayout();
            this.ppnl.SuspendLayout();
            this.pnel.SuspendLayout();
            this.pnell.SuspendLayout();
            this.ppnel.SuspendLayout();
            this.panell.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIDIncrease
            // 
            this.lblIDIncrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDIncrease.BackColor = System.Drawing.Color.White;
            this.lblIDIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIDIncrease.Image = ((System.Drawing.Image)(resources.GetObject("lblIDIncrease.Image")));
            this.lblIDIncrease.Location = new System.Drawing.Point(70, 7);
            this.lblIDIncrease.Name = "lblIDIncrease";
            this.lblIDIncrease.Size = new System.Drawing.Size(10, 15);
            this.lblIDIncrease.TabIndex = 1;
            this.lblIDIncrease.Tag = "1";
            this.lblIDIncrease.Click += new System.EventHandler(this.LblIDIncrease_Click);
            // 
            // lblIDdecrease
            // 
            this.lblIDdecrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDdecrease.BackColor = System.Drawing.Color.White;
            this.lblIDdecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIDdecrease.Image = ((System.Drawing.Image)(resources.GetObject("lblIDdecrease.Image")));
            this.lblIDdecrease.Location = new System.Drawing.Point(70, 7);
            this.lblIDdecrease.Name = "lblIDdecrease";
            this.lblIDdecrease.Size = new System.Drawing.Size(10, 15);
            this.lblIDdecrease.TabIndex = 2;
            this.lblIDdecrease.Tag = "2";
            this.lblIDdecrease.Visible = false;
            this.lblIDdecrease.Click += new System.EventHandler(this.LblIDdecrease_Click);
            // 
            // lblNameDecrease
            // 
            this.lblNameDecrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameDecrease.BackColor = System.Drawing.Color.White;
            this.lblNameDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNameDecrease.Image = ((System.Drawing.Image)(resources.GetObject("lblNameDecrease.Image")));
            this.lblNameDecrease.Location = new System.Drawing.Point(69, 7);
            this.lblNameDecrease.Name = "lblNameDecrease";
            this.lblNameDecrease.Size = new System.Drawing.Size(10, 15);
            this.lblNameDecrease.TabIndex = 3;
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
            this.lblNameIncrease.Location = new System.Drawing.Point(69, 7);
            this.lblNameIncrease.Name = "lblNameIncrease";
            this.lblNameIncrease.Size = new System.Drawing.Size(10, 15);
            this.lblNameIncrease.TabIndex = 4;
            this.lblNameIncrease.Tag = "1";
            this.lblNameIncrease.Click += new System.EventHandler(this.LblNameIncrease_Click);
            // 
            // lblTimeIncrease
            // 
            this.lblTimeIncrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeIncrease.BackColor = System.Drawing.Color.White;
            this.lblTimeIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTimeIncrease.Image = ((System.Drawing.Image)(resources.GetObject("lblTimeIncrease.Image")));
            this.lblTimeIncrease.Location = new System.Drawing.Point(116, 7);
            this.lblTimeIncrease.Name = "lblTimeIncrease";
            this.lblTimeIncrease.Size = new System.Drawing.Size(10, 15);
            this.lblTimeIncrease.TabIndex = 6;
            this.lblTimeIncrease.Tag = "1";
            this.lblTimeIncrease.Click += new System.EventHandler(this.LblTimeIncrease_Click);
            // 
            // lblTimeDecrease
            // 
            this.lblTimeDecrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeDecrease.BackColor = System.Drawing.Color.White;
            this.lblTimeDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTimeDecrease.Image = ((System.Drawing.Image)(resources.GetObject("lblTimeDecrease.Image")));
            this.lblTimeDecrease.Location = new System.Drawing.Point(116, 7);
            this.lblTimeDecrease.Name = "lblTimeDecrease";
            this.lblTimeDecrease.Size = new System.Drawing.Size(10, 15);
            this.lblTimeDecrease.TabIndex = 5;
            this.lblTimeDecrease.Tag = "2";
            this.lblTimeDecrease.Visible = false;
            this.lblTimeDecrease.Click += new System.EventHandler(this.LblTimeDecrease_Click);
            // 
            // lblPassIncrease
            // 
            this.lblPassIncrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassIncrease.BackColor = System.Drawing.Color.White;
            this.lblPassIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPassIncrease.Image = ((System.Drawing.Image)(resources.GetObject("lblPassIncrease.Image")));
            this.lblPassIncrease.Location = new System.Drawing.Point(105, 7);
            this.lblPassIncrease.Name = "lblPassIncrease";
            this.lblPassIncrease.Size = new System.Drawing.Size(10, 15);
            this.lblPassIncrease.TabIndex = 8;
            this.lblPassIncrease.Tag = "1";
            this.lblPassIncrease.Click += new System.EventHandler(this.LblPassIncrease_Click);
            // 
            // lblPassDecrease
            // 
            this.lblPassDecrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassDecrease.BackColor = System.Drawing.Color.White;
            this.lblPassDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPassDecrease.Image = ((System.Drawing.Image)(resources.GetObject("lblPassDecrease.Image")));
            this.lblPassDecrease.Location = new System.Drawing.Point(104, 7);
            this.lblPassDecrease.Name = "lblPassDecrease";
            this.lblPassDecrease.Size = new System.Drawing.Size(10, 15);
            this.lblPassDecrease.TabIndex = 7;
            this.lblPassDecrease.Tag = "2";
            this.lblPassDecrease.Visible = false;
            this.lblPassDecrease.Click += new System.EventHandler(this.LblPassDecrease_Click);
            // 
            // lblTotalIncrease
            // 
            this.lblTotalIncrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalIncrease.BackColor = System.Drawing.Color.White;
            this.lblTotalIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTotalIncrease.Image = ((System.Drawing.Image)(resources.GetObject("lblTotalIncrease.Image")));
            this.lblTotalIncrease.Location = new System.Drawing.Point(131, 7);
            this.lblTotalIncrease.Name = "lblTotalIncrease";
            this.lblTotalIncrease.Size = new System.Drawing.Size(10, 15);
            this.lblTotalIncrease.TabIndex = 10;
            this.lblTotalIncrease.Tag = "1";
            this.lblTotalIncrease.Click += new System.EventHandler(this.LblTotalIncrease_Click);
            // 
            // lblTotalDecrease
            // 
            this.lblTotalDecrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDecrease.BackColor = System.Drawing.Color.White;
            this.lblTotalDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTotalDecrease.Image = ((System.Drawing.Image)(resources.GetObject("lblTotalDecrease.Image")));
            this.lblTotalDecrease.Location = new System.Drawing.Point(131, 7);
            this.lblTotalDecrease.Name = "lblTotalDecrease";
            this.lblTotalDecrease.Size = new System.Drawing.Size(10, 15);
            this.lblTotalDecrease.TabIndex = 9;
            this.lblTotalDecrease.Tag = "2";
            this.lblTotalDecrease.Visible = false;
            this.lblTotalDecrease.Click += new System.EventHandler(this.LblTotalDecrease_Click);
            // 
            // lblCriteriaIncre
            // 
            this.lblCriteriaIncre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCriteriaIncre.BackColor = System.Drawing.Color.White;
            this.lblCriteriaIncre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCriteriaIncre.Image = ((System.Drawing.Image)(resources.GetObject("lblCriteriaIncre.Image")));
            this.lblCriteriaIncre.Location = new System.Drawing.Point(96, 7);
            this.lblCriteriaIncre.Name = "lblCriteriaIncre";
            this.lblCriteriaIncre.Size = new System.Drawing.Size(10, 15);
            this.lblCriteriaIncre.TabIndex = 12;
            this.lblCriteriaIncre.Tag = "1";
            this.lblCriteriaIncre.Click += new System.EventHandler(this.LblCriteriaIncre_Click);
            // 
            // lblCriteriaDecre
            // 
            this.lblCriteriaDecre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCriteriaDecre.BackColor = System.Drawing.Color.White;
            this.lblCriteriaDecre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCriteriaDecre.Image = ((System.Drawing.Image)(resources.GetObject("lblCriteriaDecre.Image")));
            this.lblCriteriaDecre.Location = new System.Drawing.Point(96, 7);
            this.lblCriteriaDecre.Name = "lblCriteriaDecre";
            this.lblCriteriaDecre.Size = new System.Drawing.Size(10, 15);
            this.lblCriteriaDecre.TabIndex = 11;
            this.lblCriteriaDecre.Tag = "2";
            this.lblCriteriaDecre.Visible = false;
            this.lblCriteriaDecre.Click += new System.EventHandler(this.LblCriteriaDecre_Click);
            // 
            // dgvExamList
            // 
            this.dgvExamList.AllowUserToAddRows = false;
            this.dgvExamList.AllowUserToDeleteRows = false;
            this.dgvExamList.AllowUserToResizeColumns = false;
            this.dgvExamList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dgvExamList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExamList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExamList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExamList.BackgroundColor = System.Drawing.Color.White;
            this.dgvExamList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExamList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvExamList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExamList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExamList.ColumnHeadersHeight = 40;
            this.dgvExamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExamList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExamList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExamList.EnableHeadersVisualStyles = false;
            this.dgvExamList.GridColor = System.Drawing.Color.Black;
            this.dgvExamList.Location = new System.Drawing.Point(0, 0);
            this.dgvExamList.Margin = new System.Windows.Forms.Padding(0);
            this.dgvExamList.MultiSelect = false;
            this.dgvExamList.Name = "dgvExamList";
            this.dgvExamList.ReadOnly = true;
            this.dgvExamList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExamList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExamList.RowHeadersVisible = false;
            this.dgvExamList.RowHeadersWidth = 5;
            this.dgvExamList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dgvExamList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExamList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvExamList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvExamList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExamList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dgvExamList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvExamList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dgvExamList.RowTemplate.Height = 30;
            this.dgvExamList.RowTemplate.ReadOnly = true;
            this.dgvExamList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExamList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvExamList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExamList.Size = new System.Drawing.Size(980, 492);
            this.dgvExamList.TabIndex = 13;
            this.dgvExamList.TabStop = false;
            this.dgvExamList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExamList_CellClick);
            this.dgvExamList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExamList_CellMouseEnter);
            this.dgvExamList.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExamList_CellMouseLeave);
            this.dgvExamList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvExamList_MouseClick);
            // 
            // tlp
            // 
            this.tlp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp.BackColor = System.Drawing.Color.White;
            this.tlp.ColumnCount = 8;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.350731F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.43841F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.73486F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.61378F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.73486F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.73486F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.65762F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.73486F));
            this.tlp.Controls.Add(this.pnl, 1, 0);
            this.tlp.Controls.Add(this.panel, 2, 0);
            this.tlp.Controls.Add(this.pnll, 3, 0);
            this.tlp.Controls.Add(this.ppnl, 5, 0);
            this.tlp.Controls.Add(this.pnel, 6, 0);
            this.tlp.Controls.Add(this.pnell, 7, 0);
            this.tlp.Controls.Add(this.ppnel, 0, 0);
            this.tlp.Controls.Add(this.panell, 4, 0);
            this.tlp.Location = new System.Drawing.Point(2, 2);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 1;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp.Size = new System.Drawing.Size(975, 35);
            this.tlp.TabIndex = 14;
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.lblNameDecrease);
            this.pnl.Controls.Add(this.lblNameIncrease);
            this.pnl.Controls.Add(this.lblName);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(84, 3);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(95, 29);
            this.pnl.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 29);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblIDIncrease);
            this.panel.Controls.Add(this.lblIDdecrease);
            this.panel.Controls.Add(this.lblID);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(185, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(118, 29);
            this.panel.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblID.Location = new System.Drawing.Point(0, 0);
            this.lblID.Margin = new System.Windows.Forms.Padding(0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(118, 29);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnll
            // 
            this.pnll.Controls.Add(this.lblTimeDecrease);
            this.pnll.Controls.Add(this.lblTimeIncrease);
            this.pnll.Controls.Add(this.lblTime);
            this.pnll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnll.Location = new System.Drawing.Point(309, 3);
            this.pnll.Name = "pnll";
            this.pnll.Size = new System.Drawing.Size(136, 29);
            this.pnll.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(136, 29);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "Effective Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ppnl
            // 
            this.ppnl.Controls.Add(this.lblPassDecrease);
            this.ppnl.Controls.Add(this.lblPassIncrease);
            this.ppnl.Controls.Add(this.lblPass);
            this.ppnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppnl.Location = new System.Drawing.Point(575, 3);
            this.ppnl.Name = "ppnl";
            this.ppnl.Size = new System.Drawing.Size(118, 29);
            this.ppnl.TabIndex = 3;
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.Color.White;
            this.lblPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPass.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblPass.Location = new System.Drawing.Point(0, 0);
            this.lblPass.Margin = new System.Windows.Forms.Padding(0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(118, 29);
            this.lblPass.TabIndex = 17;
            this.lblPass.Text = "Pass Criteria";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnel
            // 
            this.pnel.Controls.Add(this.lblTotalDecrease);
            this.pnel.Controls.Add(this.lblTotalIncrease);
            this.pnel.Controls.Add(this.lblTotal);
            this.pnel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnel.Location = new System.Drawing.Point(699, 3);
            this.pnel.Name = "pnel";
            this.pnel.Size = new System.Drawing.Size(146, 29);
            this.pnel.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(146, 29);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Exam/TotalScore";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnell
            // 
            this.pnell.Controls.Add(this.lblCriteriaDecre);
            this.pnell.Controls.Add(this.lblCriteriaIncre);
            this.pnell.Controls.Add(this.lblOperation);
            this.pnell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnell.Location = new System.Drawing.Point(851, 3);
            this.pnell.Name = "pnell";
            this.pnell.Size = new System.Drawing.Size(121, 29);
            this.pnell.TabIndex = 5;
            // 
            // lblOperation
            // 
            this.lblOperation.BackColor = System.Drawing.Color.White;
            this.lblOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOperation.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblOperation.Location = new System.Drawing.Point(0, 0);
            this.lblOperation.Margin = new System.Windows.Forms.Padding(0);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(121, 29);
            this.lblOperation.TabIndex = 16;
            this.lblOperation.Text = "Operation";
            this.lblOperation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ppnel
            // 
            this.ppnel.Controls.Add(this.lblNo);
            this.ppnel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppnel.Location = new System.Drawing.Point(3, 3);
            this.ppnel.Name = "ppnel";
            this.ppnel.Size = new System.Drawing.Size(75, 29);
            this.ppnel.TabIndex = 6;
            // 
            // lblNo
            // 
            this.lblNo.BackColor = System.Drawing.Color.White;
            this.lblNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNo.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblNo.Location = new System.Drawing.Point(0, 0);
            this.lblNo.Margin = new System.Windows.Forms.Padding(0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(75, 29);
            this.lblNo.TabIndex = 15;
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panell
            // 
            this.panell.Controls.Add(this.lblDuration);
            this.panell.Location = new System.Drawing.Point(451, 3);
            this.panell.Name = "panell";
            this.panell.Size = new System.Drawing.Size(118, 29);
            this.panell.TabIndex = 7;
            // 
            // lblDuration
            // 
            this.lblDuration.BackColor = System.Drawing.Color.White;
            this.lblDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDuration.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblDuration.Location = new System.Drawing.Point(0, 0);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(118, 29);
            this.lblDuration.TabIndex = 18;
            this.lblDuration.Text = "Duration";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExamList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp);
            this.Controls.Add(this.dgvExamList);
            this.Name = "ExamList";
            this.Size = new System.Drawing.Size(980, 340);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamList)).EndInit();
            this.tlp.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.pnll.ResumeLayout(false);
            this.ppnl.ResumeLayout(false);
            this.pnel.ResumeLayout(false);
            this.pnell.ResumeLayout(false);
            this.ppnel.ResumeLayout(false);
            this.panell.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        public DataGridView GetDgvExamList() 
        {
            return this.dgvExamList;
        }
        private Label lblIDIncrease;
        private Label lblIDdecrease;
        private Label lblNameDecrease;
        private Label lblNameIncrease;
        private Label lblTimeIncrease;
        private Label lblTimeDecrease;
        private Label lblPassIncrease;
        private Label lblPassDecrease;
        private Label lblTotalIncrease;
        private Label lblTotalDecrease;
        private Label lblCriteriaIncre;
        private Label lblCriteriaDecre;
        private DataGridView dgvExamList;
        private TableLayoutPanel tlp;
        private Panel pnl;
        private Panel panel;
        private Panel pnll;
        private Panel ppnl;
        private Panel pnel;
        private Panel pnell;
        private Panel ppnel;
        private Panel panell;
        private Label lblNo;
        private Label lblOperation;
        private Label lblName;
        private Label lblPass;
        private Label lblDuration;
        private Label lblTime;
        private Label lblID;
        private Label lblTotal;
        
    }
}
