using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using OesUI.ExamService;
using OesUI.utils;

namespace OesUI.Custom
{
    public partial class ExamList : UserControl
    {
        private ExamService.ExamServiceClient examManager;

        public ExamList()
        {
            if (Process.GetCurrentProcess().ProcessName != "devenv")
            {
                examManager = new ExamService.ExamServiceClient();
            }
            InitializeComponent();
        }

        //extract repeated code
        private void DynamicSort(ExamService.ExamServiceClient examManager, string SortColumn, string SortDirection)
        {
            QueryExamState.SortColumn = SortColumn;
            QueryExamState.SortDirection = SortDirection;
            
            UserDS.SearchExamDataTable table = examManager.SearchExam(QueryExamState.SortColumn, QueryExamState.SortDirection,
                ((MyExam)this.Parent).GetCurrentPage(),((MyExam)this.Parent).GetPageSize(), 
                QueryExamState.KeywordState, RememberUserParameter.username);
            this.dgvExamList.DataSource = DataTableUtils.ConvertDataTable(table);
        }

        //Sort
        //ID
        private void LblIDIncrease_Click(object sender, EventArgs e)
        {
            this.lblIDdecrease.Visible = true;
            this.lblIDIncrease.Visible = false;
            DynamicSort(examManager, Constants.ID_COLUMN, Constants.DECREASE);
        }

        private void LblIDdecrease_Click(object sender, EventArgs e)
        {
            this.lblIDdecrease.Visible = false;
            this.lblIDIncrease.Visible = true;
            DynamicSort(examManager, Constants.ID_COLUMN, Constants.INCREASE);
        }

        //Name
        private void LblNameDecrease_Click(object sender, EventArgs e)
        {
            this.lblNameDecrease.Visible = false;
            this.lblNameIncrease.Visible = true;
            DynamicSort(examManager, Constants.NAME_COLUMN, Constants.INCREASE);
        }

        private void LblNameIncrease_Click(object sender, EventArgs e)
        {
            this.lblNameDecrease.Visible = true;
            this.lblNameIncrease.Visible = false;
            DynamicSort(examManager, Constants.NAME_COLUMN, Constants.DECREASE);
        }

        //time
        private void LblTimeDecrease_Click(object sender, EventArgs e)
        {
            this.lblTimeDecrease.Visible = false;
            this.lblTimeIncrease.Visible = true;
            DynamicSort(examManager, Constants.EFFECTIVE_TIME_COLUMN, Constants.INCREASE);
        }

        private void LblTimeIncrease_Click(object sender, EventArgs e)
        {
            this.lblTimeDecrease.Visible = true;
            this.lblTimeIncrease.Visible = false;
            DynamicSort(examManager, Constants.EFFECTIVE_TIME_COLUMN, Constants.DECREASE);
        }

        //pass
        private void LblPassDecrease_Click(object sender, EventArgs e)
        {
            this.lblPassDecrease.Visible = false;
            this.lblPassIncrease.Visible = true;
            DynamicSort(examManager, Constants.PASS_CRITERIA_COLUMN, Constants.INCREASE);
        }

        private void LblPassIncrease_Click(object sender, EventArgs e)
        {
            this.lblPassDecrease.Visible = true;
            this.lblPassIncrease.Visible = false;
            DynamicSort(examManager, Constants.PASS_CRITERIA_COLUMN, Constants.DECREASE);
        }

        //total
        private void LblTotalDecrease_Click(object sender, EventArgs e)
        {
            this.lblTotalDecrease.Visible = false;
            this.lblTotalIncrease.Visible = true;
            DynamicSort(examManager, Constants.TOTAL_SCORE_COLUMN, Constants.INCREASE);
        }

        private void LblTotalIncrease_Click(object sender, EventArgs e)
        {
            this.lblTotalDecrease.Visible = true;
            this.lblTotalIncrease.Visible = false;
            DynamicSort(examManager, Constants.TOTAL_SCORE_COLUMN, Constants.DECREASE);
        }

        //criteria
        private void LblCriteriaDecre_Click(object sender, EventArgs e)
        {
            this.lblCriteriaDecre.Visible = false;
            this.lblCriteriaIncre.Visible = true;
            DynamicSort(examManager, Constants.OPERATION_COLUMN, Constants.INCREASE);
        }

        private void LblCriteriaIncre_Click(object sender, EventArgs e)
        {
            this.lblCriteriaDecre.Visible = true;
            this.lblCriteriaIncre.Visible = false;
            
            DynamicSort(examManager, Constants.OPERATION_COLUMN, Constants.DECREASE);
        }

        //datagridview bgcolor
        private void DgvExamList_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvExamList.CurrentRow != null)
            {
                dgvExamList.Rows[dgvExamList.CurrentRow.Index].DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            }
        }

        //Do it
        private void DgvExamList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && this.dgvExamList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Equals(Constants.DO_IT))
            {
                Form parentForm = (Form)this.Parent.Parent.Parent.Parent;
                FormPassValue.languageState = Thread.CurrentThread.CurrentCulture.ToString();
                FormPassValue.currentWindowState = parentForm.WindowState;

                ExamDescription examDescription = new ExamDescription();
                FormPassValue.examId = Convert.ToInt32(this.dgvExamList.Rows[e.RowIndex].Cells[2].Value);
                DialogResult result = examDescription.ShowDialog();

                if (result == DialogResult.OK)
                {
                    //Don't write outside, that run form take exam timer
                    FormTakeExam formTakeExam = new FormTakeExam();

                    //Show take exam form and transfer main form object
                    formTakeExam.Show(parentForm);

                    //Hide main form
                    parentForm.Hide();
                }
            }
        }

        //highlight
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
    }
}
