using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using OesUI.ExamService;
using OesUI.utils;

namespace OesUI.TeacherUI
{
    public partial class TeacherExamListForm : Form
    {
        private PaginationUtils paginationUtils;
        private int[] pageSizeCollection = new int[] { 5, 10, 15 };
        private ExamService.ExamServiceClient examManager;
        private DateTime fromDate = DateTime.Parse("2015-01-01");
        private DateTime toDate = DateTime.Now;
        private string examName = null;
        private const string SEARCH_MES = "searchMessage";
        private const string EXAMLIST = "examList";
        private const string DATE_FORMAT = "yyyy-MM-dd";
        public const int VM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public TeacherExamListForm()
        {
            if (Process.GetCurrentProcess().ProcessName != "devenv")
            {
                examManager = new ExamService.ExamServiceClient();
            }
            
            InitializeComponent();

            this.mcFrom.SetDate(fromDate);
            this.mcTo.SetDate(DateTime.Now);
            this.dtpFrom.Text = this.mcFrom.SelectionStart.ToString(DATE_FORMAT);
            this.dtpTo.Text = this.mcTo.SelectionStart.ToString(DATE_FORMAT);
            
            SetResourceCulture();
        }

        private void SetResourceCulture()
        {
            this.lblLanguage.Text = ResourceCulture.GetString(Constants.LANGUAGE);
            this.tbSearch.Text = ResourceCulture.GetString(SEARCH_MES);
            this.lblHome.Text = ResourceCulture.GetString(EXAMLIST);
            this.lblLogout.Text = ResourceCulture.GetString(Constants.LOGOUT);
            this.customTipDialog1.ChangeLanguage();
        }

        private void LblLanguage_Click(object sender, EventArgs e)
        {
            if (this.lblLanguage.Text.Equals(Constants.ENGLISH))
            {
                ResourceCulture.SetCurrentCulture(Constants.EN);
            }
            else
            {
                ResourceCulture.SetCurrentCulture(Constants.CH);
            }
            this.SetResourceCulture();
        }

        private void DynamicSort(string SortColumn, string SortDirection)
        {
            TeacherQueryExamListState.SortColumn = SortColumn;
            TeacherQueryExamListState.SortDirection = SortDirection;

            TeacherExamManager.SearchExamListDataTable table = examManager.GetTeacherExamList(TeacherQueryExamListState.SortColumn, TeacherQueryExamListState.SortDirection,
                paginationUtils.CurrentPage, paginationUtils.PageSize, this.fromDate, this.toDate, this.examName);
            this.dgvExamList.DataSource = table;
            EditDataGridView();
        }

        //Sort
        //ID
        private void LblIDIncrease_Click(object sender, EventArgs e)
        {
            this.lblIDdecrease.Visible = true;
            this.lblIDIncrease.Visible = false;
            DynamicSort(Constants.ID_COLUMN, Constants.DECREASE);
        }

        private void LblIDdecrease_Click(object sender, EventArgs e)
        {
            this.lblIDdecrease.Visible = false;
            this.lblIDIncrease.Visible = true;
            DynamicSort(Constants.ID_COLUMN, Constants.INCREASE);
        }

        //Name
        private void LblNameDecrease_Click(object sender, EventArgs e)
        {
            this.lblNameDecrease.Visible = false;
            this.lblNameIncrease.Visible = true;
            DynamicSort(Constants.NAME_COLUMN, Constants.INCREASE);
        }

        private void LblNameIncrease_Click(object sender, EventArgs e)
        {
            this.lblNameDecrease.Visible = true;
            this.lblNameIncrease.Visible = false;
            DynamicSort(Constants.NAME_COLUMN, Constants.DECREASE);
        }

        //time
        private void LblTimeDecrease_Click(object sender, EventArgs e)
        {
            this.lblTimeDecrease.Visible = false;
            this.lblTimeIncrease.Visible = true;
            DynamicSort(Constants.EFFECTIVE_TIME_COLUMN, Constants.INCREASE);
        }

        private void LblTimeIncrease_Click(object sender, EventArgs e)
        {
            this.lblTimeDecrease.Visible = true;
            this.lblTimeIncrease.Visible = false;
            DynamicSort(Constants.EFFECTIVE_TIME_COLUMN, Constants.DECREASE);
        }

        //pass
        private void LblPassDecrease_Click(object sender, EventArgs e)
        {
            this.lblPassDecrease.Visible = false;
            this.lblPassIncrease.Visible = true;
            DynamicSort(Constants.PASS_RATE_COLUMN, Constants.INCREASE);
        }

        private void LblPassIncrease_Click(object sender, EventArgs e)
        {
            this.lblPassDecrease.Visible = true;
            this.lblPassIncrease.Visible = false;
            DynamicSort(Constants.PASS_RATE_COLUMN, Constants.DECREASE);
        }

        //average score
        private void LblAverageDecrease_Click(object sender, EventArgs e)
        {
            this.lblAverageDecrease.Visible = false;
            this.lblAverageIncrease.Visible = true;
            DynamicSort(Constants.AVERAGE_COLUMN, Constants.INCREASE);
        }

        private void LblAverageIncrease_Click(object sender, EventArgs e)
        {
            this.lblAverageDecrease.Visible = true;
            this.lblAverageIncrease.Visible = false;
            DynamicSort(Constants.AVERAGE_COLUMN, Constants.DECREASE);
        }

        private void TeacherExamListForm_Load(object sender, EventArgs e)
        {
            paginationUtils = new PaginationUtils(this.pnlPagination, this.customTipDialog1, pageSizeCollection, QueryPaginationData, this.myOpaqueLayer);
            this.lblCurrentUser.Text = RememberUserParameter.username;

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

        //query pagination data
        private void QueryPaginationData()
        {
            paginationUtils.TotalRecord = examManager.GetTeacherExamListCount(fromDate, toDate, examName);
            TeacherExamManager.SearchExamListDataTable table = examManager.GetTeacherExamList(TeacherQueryExamListState.SortColumn, TeacherQueryExamListState.SortDirection,
                paginationUtils.CurrentPage, paginationUtils.PageSize, fromDate, toDate, examName);
            this.dgvExamList.DataSource = table;
            EditDataGridView();
        }

        //set datagridview style
        private void EditDataGridView()
        {
            DataGridView dataGrid = this.dgvExamList;
            for (int j = 0; j < dataGrid.Rows.Count; j++)
            {
                for (int i = 0; i < dataGrid.Columns.Count; i++)
                {
                    if (i == 1)
                    {
                        dataGrid[i, j].Style.ForeColor = Color.FromArgb(0x29, 0x67, 0x93);
                    }
                }
            }

            dataGrid.Columns[0].Width = 50;
            dataGrid.Columns[1].Width = 55;
            dataGrid.Columns[2].Width = 50;
            dataGrid.Columns[3].Width = 120;
            dataGrid.Columns[4].Width = 170;
            dataGrid.Columns[5].Width = 120;
            dataGrid.Columns[6].Width = 120;
            dataGrid.Columns[7].Width = 150;
            dataGrid.Columns[8].Width = 100;
        }

        private void DgvExamList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvExamList.Rows[e.RowIndex].Selected = true;
                dgvExamList.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            }
        }

        private void DgvExamList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvExamList.Rows[e.RowIndex].Selected = false;
                dgvExamList.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.White;
            }
        }

        private void DgvExamList_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvExamList.CurrentRow != null)
            {
                dgvExamList.Rows[dgvExamList.CurrentRow.Index].DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            }
        }

        private void LblSearchIcon_Click(object sender, EventArgs e)
        {
            SearchOperation();
        }

        //search student exam result
        private void SearchOperation()
        {
            string tbExamName = this.tbSearch.Text.Trim();
            
            if (this.dtpFrom.Text.Equals(string.Empty) && this.dtpTo.Text.Equals(string.Empty))
            {
                this.dtpFrom.Text = fromDate.ToString(DATE_FORMAT);
                this.dtpTo.Text = DateTime.Now.ToString(DATE_FORMAT);
            }

            if (!this.dtpFrom.Text.Equals(string.Empty) && this.dtpTo.Text.Equals(string.Empty))
            {
                this.dtpTo.Text = this.dtpFrom.Text;
            }

            if (this.dtpFrom.Text.Equals(string.Empty) && !this.dtpTo.Text.Equals(string.Empty))
            {
                this.dtpFrom.Text = this.dtpTo.Text;
            }

            DateTime from = DateTime.Parse(this.dtpFrom.Text);
            DateTime to = DateTime.Parse(this.dtpTo.Text);
            this.fromDate = from;
            this.toDate = to;

            if (tbExamName.Equals(string.Empty) || tbExamName.Equals(ResourceCulture.GetString(SEARCH_MES)))
            {
                this.examName = null;
            }
            else
            {
                tbExamName = EscapeSpecialCharacter.EscapeDatabaseCharacter(tbExamName);
                this.examName = tbExamName;
            }

            paginationUtils.CurrentPage = 1;
            GetAllExamData();
        }

        private void TbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            this.mcFrom.Hide();
            this.mcTo.Hide();
            if (this.tbSearch.Text.Equals(ResourceCulture.GetString(SEARCH_MES)))
            {
                this.tbSearch.Text = string.Empty;
            }
        }

        //Open exam detail form
        private void DgvExamList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                FormPassValue.examDetailExamId = Convert.ToInt32(this.dgvExamList[e.ColumnIndex - 1, e.RowIndex].Value);
                FormPassValue.languageState = Thread.CurrentThread.CurrentCulture.ToString();
                FormPassValue.currentWindowState = this.WindowState;
                ExamDetailForm form = new ExamDetailForm();
                form.ShowDialog();
            }
        }

        private void TbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SearchOperation();
            }
        }

        private void TbSearch_Leave(object sender, EventArgs e)
        {
            if (this.tbSearch.Text.Trim().Equals(string.Empty))
            {
                this.tbSearch.Text = ResourceCulture.GetString(SEARCH_MES);
            }
        }

        private void LblLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void LblCurrentUser_Click(object sender, EventArgs e)
        {
            FormPassValue.currentWindowState = this.WindowState;
            FormPassValue.languageState = Thread.CurrentThread.CurrentCulture.ToString();
            FormPassValue.whichRole = Constants.Teacher_Role;

            UserProfileForm form = new UserProfileForm();
            this.Hide();
            DialogResult result = form.ShowDialog(this);
        }

        private void TbSearch_MouseLeave(object sender, EventArgs e)
        {
            this.dgvExamList.Focus();
        }

        private void McFrom_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.dtpFrom.Text = this.mcFrom.SelectionStart.ToString("yyyy-MM-dd");
            this.mcFrom.Hide();
        }

        private void McTo_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.dtpTo.Text = this.mcTo.SelectionStart.ToString("yyyy-MM-dd");
            this.mcTo.Hide();
        }

        private void DtpFrom_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.mcFrom.Visible == true)
            {
                this.mcFrom.Hide();
            }
            else
            {
                this.mcFrom.Show();
            }
            this.mcTo.Hide();
        }

        private void DtpTo_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.mcTo.Visible ==true)
            {
                this.mcTo.Hide();
            }
            else
            {
                this.mcTo.Show();
            }
            this.mcFrom.Hide();
        }

        private void LblDate_Click(object sender, EventArgs e)
        {
            this.dtpFrom.Text = string.Empty;
            this.dtpTo.Text = string.Empty;
        }

        private void PnlExamList_Click(object sender, EventArgs e)
        {
            this.mcFrom.Hide();
            this.mcTo.Hide();
        }
    }
}
