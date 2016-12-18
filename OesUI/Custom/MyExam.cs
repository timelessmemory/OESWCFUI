using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using OesUI.ExamService;
using OesUI.utils;

namespace OesUI.Custom
{
    public partial class MyExam : UserControl
    {
        private const string SHOW_WHICH_SORT_ICON = "1";
        private Color stateBackColor = Color.FromArgb(46, 67, 88);
        private Color gridViewColor = Color.FromArgb(0x29, 0x67, 0x93);
        private Font doItFont = new Font(Constants.ARIAL, 9, FontStyle.Underline);
        private int[] pageSizeCollection = new int[] { 5, 10, 15};
        private ExamService.ExamServiceClient examManager;
        private PaginationUtils paginationUtils;
        private const string DO_IT = "Do it";
        private MyOpaqueLayer myOpaqueLayer;
        private CustomTipDialog custTipDialog;

        public MyExam()
        {
            if (Process.GetCurrentProcess().ProcessName != "devenv")
            {
                examManager = new ExamService.ExamServiceClient();
            }

            InitializeComponent();
        }

        public void SetMyOpaqueLayer(MyOpaqueLayer myOpaqueLayer, CustomTipDialog custTipDialog)
        {
            this.myOpaqueLayer = myOpaqueLayer;
            this.custTipDialog = custTipDialog;
        }

        public int GetCurrentPage()
        {
            return paginationUtils.CurrentPage;
        }

        public int GetPageSize()
        {
            return paginationUtils.PageSize;
        }

        //reset sort direction
        private void ResetSortBtn(UserControl userControl)
        {
            foreach (Control item in userControl.Controls)
            {
                if (item is Label)
                {
                    Label label = item as Label;
                    if (label.Tag.Equals(SHOW_WHICH_SORT_ICON))
                    {
                        label.Visible = true;
                    }
                    else
                    {
                        label.Visible =false;
                    }
                }
            }
        }

        //Tab
        private void LblAll_Click(object sender, EventArgs e)
        {
            //reset parameter and update all exam data
            QueryExamState.KeywordState = Constants.ALLSTATE;
            QueryExamState.SortColumn = Constants.ID_COLUMN;
            QueryExamState.SortDirection = Constants.INCREASE;
            paginationUtils.CurrentPage = 1;
            ResetSortBtn(this.AllExam);
            GetAllExamData();

            this.lblAll.BackColor = stateBackColor;
            this.lblAll.ForeColor = Color.White;

            this.lblFinishedExam.BackColor = Color.White;
            this.lblFinishedExam.ForeColor = Color.Black;

            this.lblUnfinishedExam.BackColor = Color.White;
            this.lblUnfinishedExam.ForeColor = Color.Black;
        }

        private void LblFinishedExam_Click(object sender, EventArgs e)
        {
            //reset parameter and update finished exam data
            QueryExamState.KeywordState = Constants.FINISHEDSTATE;
            QueryExamState.SortColumn = Constants.ID_COLUMN;
            QueryExamState.SortDirection = Constants.INCREASE;
            paginationUtils.CurrentPage = 1;
            GetFinishedExamData();

            this.lblAll.BackColor = Color.White;
            this.lblAll.ForeColor = Color.Black;

            this.lblFinishedExam.BackColor = stateBackColor;
            this.lblFinishedExam.ForeColor = Color.White;

            this.lblUnfinishedExam.BackColor = Color.White;
            this.lblUnfinishedExam.ForeColor = Color.Black;
        }

        private void LblUnfinishedExam_Click(object sender, EventArgs e)
        {
            //reset parameter and update unfinished exam data
            QueryExamState.KeywordState = Constants.UNFINISHEDSTATE;
            QueryExamState.SortColumn = Constants.ID_COLUMN;
            QueryExamState.SortDirection = Constants.INCREASE;
            paginationUtils.CurrentPage = 1;
            GetUnfinishedExamData();

            this.lblAll.BackColor = Color.White;
            this.lblAll.ForeColor = Color.Black;

            this.lblFinishedExam.BackColor = Color.White;
            this.lblFinishedExam.ForeColor = Color.Black;

            this.lblUnfinishedExam.BackColor = stateBackColor;
            this.lblUnfinishedExam.ForeColor = Color.White;
        }

        private void GetUnfinishedExamData()
        {
            QueryPaginationData();
            paginationUtils.CustPagination(paginationUtils.CurrentPage, paginationUtils.TotalPage);
        }

        private void GetFinishedExamData()
        {
            QueryPaginationData();
            paginationUtils.CustPagination(paginationUtils.CurrentPage, paginationUtils.TotalPage);
        }

        private void GetAllExamData()
        {
            QueryPaginationData();
            paginationUtils.CustPagination(paginationUtils.CurrentPage, paginationUtils.TotalPage);
        }

        private void AllExam_Load(object sender, EventArgs e)
        {
            if (Process.GetCurrentProcess().ProcessName != "devenv")
            {
                paginationUtils = new PaginationUtils(this.pnlPagination, this.custTipDialog, 
                    pageSizeCollection, QueryPaginationData, this.myOpaqueLayer);
                GetAllExamData();
            }
        }

        //Query Pagination data
        private void QueryPaginationData()
        {
            paginationUtils.TotalRecord = examManager.GetExamCount(RememberUserParameter.username, QueryExamState.KeywordState);
            UserDS.SearchExamDataTable table = examManager.SearchExam(QueryExamState.SortColumn, QueryExamState.SortDirection,
                paginationUtils.CurrentPage, paginationUtils.PageSize, QueryExamState.KeywordState, RememberUserParameter.username);
            this.AllExam.GetDgvExamList().DataSource = DataTableUtils.ConvertDataTable(table);
            EditDataGridView();
        }

        //Set datagridview style
        private void EditDataGridView()
        {
            DataGridView dataGrid = this.AllExam.GetDgvExamList();
            for (int j = 0; j < dataGrid.Rows.Count; j++)
            {
                for (int i = 0; i < dataGrid.Columns.Count; i++)
                {
                    dataGrid.Columns[i].Width = (int)(this.Width * (122.0 / 958));

                    if (i == 1)
                    {
                        dataGrid[i, j].Style.ForeColor = gridViewColor;
                    }

                    if (i == 7 && (dataGrid[i, j].Value.ToString()).Equals(DO_IT))
                    {
                        dataGrid[i, j].Style.ForeColor = gridViewColor;
                        dataGrid[i, j].Style.Font = doItFont;
                    }
                }
            }

            dataGrid.Columns[0].Width = (int)(this.Width * (80.0 / 958));
            dataGrid.Columns[1].Width = (int)(this.Width * (100.0 / 958));
            dataGrid.Columns[3].Width = (int)(this.Width * (140.0 / 958));
            dataGrid.Columns[6].Width = (int)(this.Width * (150.0 / 958));
        }
    }
}
