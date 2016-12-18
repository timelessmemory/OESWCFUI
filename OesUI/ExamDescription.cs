using System;
using System.Data;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using OesUI.ExamService;
using OesUI.utils;

namespace OesUI
{
    public partial class ExamDescription : Form
    {
        private ExamService.ExamServiceClient examManager = new ExamService.ExamServiceClient();
        private QuestionService.QuestionServiceClient questionManager = new QuestionService.QuestionServiceClient();
        private const string HAVE_NOT_START_MESSAGE = "haveNotStartMessage";
        private const string HAVE_END = "haveEndMessage";
        private const string ZERO = "0";
        private const string DAY = "day";
        private const string Colon = ":";
        private const string EOO = "E00";
        private const string Min = "min";
        private const string EXAM_DES = "examDescription";
        private const string End_Time = "endTime";
        private const string Start_Time = "startTime";
        private const string Return_Key = "return";
        private const string Start_Test_Key = "startTest";
        private DateTime effectiveTime;
        private const string CONFIRM = "confirm";
        private const string HAVE_TOKEN_EXAM = "haveToken";

        public ExamDescription()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo(FormPassValue.languageState);
            SetResourceCulture();
        }

        private void SetResourceCulture()
        {
            this.lblTitle.Text = ResourceCulture.GetString(EXAM_DES);
            this.lblName.Text = ResourceCulture.GetString(Constants.Exam_Name_Label);
            this.lblEffective.Text = ResourceCulture.GetString(Constants.Effective_Time);
            this.lblDuration.Text = ResourceCulture.GetString(Constants.Duration);
            this.lblQuestion.Text = ResourceCulture.GetString(Constants.Question_Count);
            this.lblId.Text = ResourceCulture.GetString(Constants.ID);
            this.lblEndTime.Text = ResourceCulture.GetString(End_Time);
            this.lblTotal.Text = ResourceCulture.GetString(Constants.Total_Score);
            this.lblstart.Text = ResourceCulture.GetString(Start_Time);
            this.Return.Text = ResourceCulture.GetString(Return_Key);
            this.StartTest.Text = ResourceCulture.GetString(Start_Test_Key);
            this.btnConfirm.Text = ResourceCulture.GetString(CONFIRM);
        }

        //start take exam
        private void StartTest_Click(object sender, EventArgs e)
        {
            ExamDS.exam_exceptionDataTable datatable = examManager.GetExceptionOccurTime(RememberUserParameter.userId, FormPassValue.examId);
            FormPassValue.currentWindowState = this.WindowState;

            //exception
            if (datatable.Rows.Count > 0)
            {
                DateTime exceptiontime;
                var rs = from dt in datatable select new { dt.occur_time };

                foreach (var item in rs)
                {
                    exceptiontime = item.occur_time;
                }

                //if (DateTime.Now - exceptiontime)
                //whether add exption duration to endtime
                int haveAnsweredNum = questionManager.QueryHaveAnsweredQuestionNumber(RememberUserParameter.userId, FormPassValue.examId);
                
                //begin from which question
                FormPassValue.questionSerial = haveAnsweredNum + 1;
                this.DialogResult = DialogResult.OK;
            }
            else
            //normal
            {
                TimeSpan tsNow = new TimeSpan((DateTime.Now).Ticks);
                TimeSpan tsEffective = new TimeSpan(effectiveTime.Ticks);
                double timeInterval = tsEffective.Subtract(tsNow).TotalSeconds;
                bool result = examManager.ValidationIsHasTokenExam(RememberUserParameter.userId, FormPassValue.examId);

                if (timeInterval > 0)
                {
                    this.lblHintMessage.Text = ResourceCulture.GetString(HAVE_NOT_START_MESSAGE);
                    this.pnlHint.Visible = true;
                }
                else if (result == true)
                {
                    this.lblHintMessage.Text = ResourceCulture.GetString(HAVE_TOKEN_EXAM);
                    this.pnlHint.Visible = true;
                }
                else
                {
                    TimeSpan tsEnd = new TimeSpan(FormPassValue.endTime.Ticks);
                    double endTimeInterval = tsNow.Subtract(tsEnd).TotalSeconds;

                    if (endTimeInterval >= 0)
                    {
                        this.lblHintMessage.Text = ResourceCulture.GetString(HAVE_END);
                        this.pnlHint.Visible = true;
                        return;
                    }

                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        //timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            TimeSpan durationTime = effectiveTime - Now;
            string tsDay = durationTime.Days.ToString();
            string tsHour = durationTime.Hours.ToString();
            string tsMin = durationTime.Minutes.ToString();
            string tsSecond = durationTime.Seconds.ToString();

            if (tsDay.Equals(ZERO))
            {
                this.TimerShow.Text = tsHour + Colon + tsMin + Colon + tsSecond;
            }
            else
            {
                this.TimerShow.Text = tsDay + ResourceCulture.GetString(DAY) + tsHour + Colon + tsMin + Colon + tsSecond;
            }
        }

        //Show exam information and transfer value
        private void ExamDescription_Load(object sender, EventArgs e)
        {
            this.WindowState = FormPassValue.currentWindowState;
            QueryExamInfo();
            timer1.Start();
        }

        /// <summary>
        /// Query exam information
        /// </summary>
        private void QueryExamInfo()
        {
            int examId = FormPassValue.examId;
            var exam = examManager.GetExamById(examId);

            //just get one record
            foreach (var item in exam)
            {
                FormPassValue.eachQuestionPoint = item.single_question_score;
                FormPassValue.passCriteria = item.pass_criteria;

                FormPassValue.examName = item.exam_name;
                this.lblNameValue.Text = FormPassValue.examName;
                this.lblIdValue.Text = EOO + examId;

                DateTime TmpEffectiveTime = item.effective_time;
                effectiveTime = TmpEffectiveTime;
                FormPassValue.effectiveTime = TmpEffectiveTime;
                this.lblEffectiveTimeValue.Text = TmpEffectiveTime.ToString();

                FormPassValue.endTime = TmpEffectiveTime.AddMinutes(item.duration);
                this.lblEndTimeValue.Text = FormPassValue.endTime.ToString();
                FormPassValue.duration = item.duration;
                this.lblDurationvalue.Text = FormPassValue.duration + ResourceCulture.GetString(Min);

                FormPassValue.totalScore = item.total_score;
                this.lblTotalScoreValue.Text = FormPassValue.totalScore.ToString();

                FormPassValue.questionQuantity = item.question_quantity;
                this.lblQuestionCountValue.Text = FormPassValue.questionQuantity.ToString();
            }
        }

        //Hide hint panel
        private void LblHintClose_Click(object sender, EventArgs e)
        {
            this.pnlHint.Visible = false;
        }

        //Hide hint panel
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            this.pnlHint.Visible = false;
        }
    }
}
