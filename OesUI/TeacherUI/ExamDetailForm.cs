using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using OesUI.ExamService;
using OesUI.utils;

namespace OesUI.TeacherUI
{
    public partial class ExamDetailForm : Form
    {
        private PaginationUtils paginationUtils;
        private int[] pageSizeCollection = new int[] { 5, 10, 15 };
        private ExamService.ExamServiceClient examManager;
        private string studentName = null;
        private const string SEARCH_MES = "searchMessage";

        public ExamDetailForm()
        {
            if (Process.GetCurrentProcess().ProcessName != "devenv")
            {
                examManager = new ExamService.ExamServiceClient();
            }
            
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo(FormPassValue.languageState);
            SetResourceCulture();
        }

        private void SetResourceCulture()
        {
            this.tbSearch.Text = ResourceCulture.GetString(SEARCH_MES);
            this.customTipDialog1.ChangeLanguage();
        }

        private void DynamicSort(string SortColumn, string SortDirection)
        {
            ExamDetailState.SortColumn = SortColumn;
            ExamDetailState.SortDirection = SortDirection;

            TeacherExamManager.ExamListDetailDataTable table = examManager.GetExamDetail(ExamDetailState.SortColumn, 
                ExamDetailState.SortDirection, paginationUtils.CurrentPage, paginationUtils.PageSize, this.studentName,
                FormPassValue.examDetailExamId);
            this.dgvExamDetail.DataSource = table;
            EditDataGridView();
        }

        //Sort
        //score
        private void LblScoreIncrease_Click(object sender, EventArgs e)
        {
            this.lblScoreDecrease.Visible = true;
            this.lblScoreIncrease.Visible = false;
            DynamicSort(Constants.DETAIL_SCORE_COLUMN, Constants.DECREASE);
        }

        private void LblScoreDecrease_Click(object sender, EventArgs e)
        {
            this.lblScoreDecrease.Visible = false;
            this.lblScoreIncrease.Visible = true;
            DynamicSort(Constants.DETAIL_SCORE_COLUMN, Constants.INCREASE);
        }

        //Name
        private void LblNameDecrease_Click(object sender, EventArgs e)
        {
            this.lblNameDecrease.Visible = false;
            this.lblNameIncrease.Visible = true;
            DynamicSort(Constants.DETAIL_NAME_COLUMN, Constants.INCREASE);
        }

        private void LblNameIncrease_Click(object sender, EventArgs e)
        {
            this.lblNameDecrease.Visible = true;
            this.lblNameIncrease.Visible = false;
            DynamicSort(Constants.DETAIL_NAME_COLUMN, Constants.DECREASE);
        }

        //result
        private void LblResultDecrease_Click(object sender, EventArgs e)
        {
            this.lblResultDecrease.Visible = false;
            this.lblResultIncrease.Visible = true;
            DynamicSort(Constants.DETAIL_RESULT_COLUMN, Constants.INCREASE);
        }

        private void LblResultIncrease_Click(object sender, EventArgs e)
        {
            this.lblResultDecrease.Visible = true;
            this.lblResultIncrease.Visible = false;
            DynamicSort(Constants.DETAIL_RESULT_COLUMN, Constants.DECREASE);
        }

        private void ExamDetailForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormPassValue.currentWindowState;
            paginationUtils = new PaginationUtils(this.pnlPagination, this.customTipDialog1,
                pageSizeCollection, QueryPaginationData, this.myOpaqueLayer);

            if (Process.GetCurrentProcess().ProcessName != "devenv")
            {
                GetAllExamData();
            }
        }

        private void GetAllExamData()
        {
            QueryPaginationData();
            paginationUtils.CustPagination(paginationUtils.CurrentPage, paginationUtils.TotalPage);
        }

        //Query pagination data
        private void QueryPaginationData()
        {
            paginationUtils.TotalRecord = examManager.GetExamDetailCount(this.studentName, FormPassValue.examDetailExamId);
            TeacherExamManager.ExamListDetailDataTable table = examManager.GetExamDetail(ExamDetailState.SortColumn, ExamDetailState.SortDirection,
                paginationUtils.CurrentPage, paginationUtils.PageSize, this.studentName, FormPassValue.examDetailExamId);
            this.dgvExamDetail.DataSource = table;
            EditDataGridView();
        }

        //Set datagridview style
        private void EditDataGridView()
        {
            DataGridView dataGrid = this.dgvExamDetail;
            for (int j = 0; j < dataGrid.Rows.Count; j++)
            {
                for (int i = 0; i < dataGrid.Columns.Count; i++)
                {
                    if (i == 3)
                    {
                        dataGrid[i, j].Style.ForeColor = Color.FromArgb(94, 94, 94);
                    }
                }
            }

            dataGrid.Columns[0].Width = Convert.ToInt32(this.Width * (95.0 / 550));
            dataGrid.Columns[1].Width = Convert.ToInt32(this.Width * (100.0 / 550));
            dataGrid.Columns[2].Width = Convert.ToInt32(this.Width * (50.0 / 550));
            dataGrid.Columns[3].Width = Convert.ToInt32(this.Width * (105.0 / 550));
            dataGrid.Columns[4].Width = Convert.ToInt32(this.Width * (200.0 / 550));
        }

        private void DgvExamList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvExamDetail.Rows[e.RowIndex].Selected = true;
                dgvExamDetail.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            }
        }

        private void DgvExamList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvExamDetail.Rows[e.RowIndex].Selected = false;
                dgvExamDetail.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.White;
            }
        }

        private void DgvExamList_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvExamDetail.CurrentRow != null)
            {
                dgvExamDetail.Rows[dgvExamDetail.CurrentRow.Index].DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            }
        }

        private void LblSearchIcon_Click(object sender, EventArgs e)
        {
            ValidateAndSubmit();
        }

        //validate data
        private void ValidateAndSubmit()
        {
            string tbStudentName = this.tbSearch.Text.Trim();

            if (tbStudentName.Equals(string.Empty) || tbStudentName.Equals(ResourceCulture.GetString(SEARCH_MES)))
            {
                this.studentName = null;
            }
            else
            {
                tbStudentName = EscapeSpecialCharacter.EscapeDatabaseCharacter(tbStudentName);
                this.studentName = tbStudentName;
            }

            paginationUtils.CurrentPage = 1;
            GetAllExamData();
        }

        private void tbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            this.tbSearch.Text = string.Empty;
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ValidateAndSubmit();
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (this.tbSearch.Text.Trim().Equals(string.Empty))
            {
                this.tbSearch.Text = ResourceCulture.GetString(SEARCH_MES);
            }
        }

        private void tbSearch_MouseLeave(object sender, EventArgs e)
        {
            this.dgvExamDetail.Focus();
        }
    }
}
