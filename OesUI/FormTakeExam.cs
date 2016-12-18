using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using OesUI.Custom;
using OesUI.ExamService;
using OesUI.QuestionService;
using OesUI.utils;

namespace OesUI
{
    public partial class FormTakeExam : Form
    {
        private const string NO = "No";
        private const string XIE = "/";
        private const string PASS = "Pass";
        private const string NOPASS = "No Pass";
        private const string CHOOSE = "Choose";
        private const string TAKE_EXAM_FRAGONE = "TakeExamFragOne";
        private const string TAKE_EXAM_FRAGTWO = "TakeExamFragTwo";
        private const string TIMING = "Timing";
        private const string SUBMIT = "Submit";
        private const string NEXT_QUESTION = "NextQuestion";
        private const string TIME_UP = "TimeUp";
        private const string TAKE_EXAM_FRAGTHREE = "TakeExamFragThree";
        private const string TAKE_EXAM_FRAGFOUR = "TakeExamFragFour";
        private const string TAKE_EXAM_FRAGFIVE = "TakeExamFragFive";
        private const string VIEW_RESULT = "ViewResult";
        private const string TAKE_EXAM_FRAGSIX = "TakeExamFragSix";
        private const string SHOW_FLAG = "1";
        private const string COLON = ":";
        private static int? questionCount;
        private QuestionService.QuestionServiceClient questionManager = new QuestionService.QuestionServiceClient();
        private ExamService.ExamServiceClient examManager = new ExamService.ExamServiceClient();
        private int currentQuestionId;
        private int studentCorrectQuestionCount;
        private double studentGetScore;

        //Current question order 
        private static int? questionNumber;

        //save DAL method return data
        private QuestionDS.ExamQuestionDataTable questionTable;

        //Store student answer
        private List<string> answerList = new List<string>();

        //Store corrext answer
        private List<string> correctAnswerList = new List<string>();
      
        //set a flag to express isfinish exam
        private bool isExit;

        /// <summary>
        /// Init parameter
        /// </summary>
        public FormTakeExam()
        {
            questionNumber = FormPassValue.questionSerial;
            studentCorrectQuestionCount = 0;
            studentGetScore = 0;
            isExit = false;

            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new CultureInfo(FormPassValue.languageState);
            SetResourceCulture();
        }

        private void SetResourceCulture()
        {
            this.lblChoose.Text = ResourceCulture.GetString(CHOOSE);
            this.lblfragmentone.Text = ResourceCulture.GetString(TAKE_EXAM_FRAGONE);
            this.lblfragmenttwo.Text = ResourceCulture.GetString(TAKE_EXAM_FRAGTWO);
            this.lblTimeTitle.Text = ResourceCulture.GetString(TIMING);
            this.btnNext.Text = ResourceCulture.GetString(NEXT_QUESTION);
            this.btnSubmit.Text = ResourceCulture.GetString(SUBMIT);
            this.lblAtuoTitle.Text = ResourceCulture.GetString(TIME_UP);
            this.lblYour.Text = ResourceCulture.GetString(TAKE_EXAM_FRAGTHREE);
            this.lblFragOne.Text = ResourceCulture.GetString(TAKE_EXAM_FRAGTHREE);
            this.lblPoint.Text = ResourceCulture.GetString(TAKE_EXAM_FRAGFOUR);
            this.lblFragTwo.Text = ResourceCulture.GetString(TAKE_EXAM_FRAGFOUR);
            this.lbltest.Text = ResourceCulture.GetString(TAKE_EXAM_FRAGFIVE);
            this.lblth.Text = ResourceCulture.GetString(TAKE_EXAM_FRAGFIVE);
            this.lblViewDetail.Text = ResourceCulture.GetString(VIEW_RESULT);
            this.lblAutoSub.Text = ResourceCulture.GetString(VIEW_RESULT);
        }

        //Show Parent window
        private void FormTakeExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if exit exception, should record time
            if (!isExit)
            {
                examManager.InsertExamExceptionTime(RememberUserParameter.userId, FormPassValue.examId, DateTime.Now);
            }

            this.Owner.Show();
        }

        /// <summary>
        /// Next question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNext_Click(object sender, EventArgs e)
        {
            questionNumber += 1;
            FillAnswer();
            FillQuestionData(questionNumber, questionCount);
            this.btnNext.Enabled = false;
            this.btnNext.Enabled = true;
        }

        //save user answer into database
        private void InsertUserAnswer(string userAnswer)
        {
            questionManager.InsertUserAnswer(RememberUserParameter.userId, FormPassValue.examId, currentQuestionId, userAnswer);
        }

        /// <summary>
        /// Record student question answer
        /// </summary>
        private void FillAnswer()
        {
            if (this.lblASelect.Visible == true)
            {
                InsertUserAnswer(this.rbtA.Text);
            }
            else if (this.lblBSelect.Visible == true)
            {
                InsertUserAnswer(this.rbtB.Text);
            }
            else if (this.lblCSelect.Visible == true)
            {
                InsertUserAnswer(this.rbtC.Text);
            }
            else if (this.lblDSelect.Visible == true)
            {
                InsertUserAnswer(this.rbtD.Text);
            }

            this.lblASelect.Show();
            lblAunselect.Hide();
            HideAndShow(this.lblASelect, lblAunselect);
        }

        //load first question
        private void FormTakeExam_Load(object sender, EventArgs e)
        {
            this.WindowState = FormPassValue.currentWindowState;
            questionCount = FormPassValue.questionQuantity;
            questionTable = questionManager.FindQuestionByExamId(FormPassValue.examId);
            FormPassValue.questionTable = questionTable;
            
            FillQuestionData(questionNumber, questionCount);
            this.lblEachPoint.Text = FormPassValue.eachQuestionPoint.ToString();
        }

        /// <summary>
        /// Fill question in exam paper
        /// </summary>
        /// <param name="questionNum"></param>
        /// <param name="questionQuantity"></param>
        private void FillQuestionData(int? questionNum, int? questionQuantity)
        {
            var afterQuestions = from q in questionTable 
                                 where Convert.ToInt32((q[NO])) == questionNum 
                                 select new
                                 { 
                                     No = (q[NO]), q.id, q.title, q.answer_a, q.answer_b, q.answer_c, q.answer_d, q.correct_answer 
                                 };
            
            foreach (var item in afterQuestions)
            {
                this.lblQuesNum.Text = questionNum.ToString();
                this.lblQuesTitle.Text = item.title;
                this.lblAnswerA.Text = item.answer_a;
                this.lblAnswerB.Text = item.answer_b;
                this.lblAnswerC.Text = item.answer_c;
                this.lblAnswerD.Text = item.answer_d;
                this.lblPercent.Text = questionNum + XIE + questionQuantity;

                currentQuestionId = item.id;
            }

            if (questionNumber == questionCount)
            {
                this.btnNext.Visible = false;
                this.btnSubmit.Visible = true;
            }
        }

        /// <summary>
        /// Student submits exam calculate result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Click(object sender, EventArgs e)
        {
            FillAnswer();

            CalculateResult(false);

            isExit = true;

            //hide exam panel
            this.pnlMainLayout.Visible = false;

            //show result panel
            this.pnlExamResult.Visible = true;
        }

        //load user answer and correct answer
        private void GetUserAnswerAndCorrectAnswer()
        {
            QuestionDS.exam_answer_detailDataTable tableAdapter = questionManager.FindUserAnswer(RememberUserParameter.userId, FormPassValue.examId);
            var rs = from s in tableAdapter select new { s.user_answer };
            foreach (var item in rs)
            {
                answerList.Add(item.user_answer);
            }

            //query correct answer
            var afterQuestions = from q in questionTable select new { q.correct_answer };
            foreach (var item in afterQuestions)
            {
                correctAnswerList.Add(item.correct_answer);
            }
        }

        /// <summary>
        /// Calculate exam result and insert result to database,
        /// then show result to student
        /// </summary>
        private void CalculateResult(bool isAutoCommit)
        {
            GetUserAnswerAndCorrectAnswer();
            FormPassValue.answerList = answerList;
            FormPassValue.correctAnswerList = correctAnswerList;

            for (int i = 0; i < answerList.Count; i++)
            {
                if (answerList[i].Equals(correctAnswerList[i]))
                {
                    studentCorrectQuestionCount++;
                    studentGetScore += FormPassValue.eachQuestionPoint;
                }
            }

            DealWithExamResult();

            if (isAutoCommit)
            {
                this.lblAutoGetScore.Text = studentGetScore.ToString();
                this.lblAutoCorrectNum.Text = studentCorrectQuestionCount.ToString();
            }
            else
            {
                this.lblGetScore.Text = studentGetScore.ToString();
                this.lblCorrectCount.Text = studentCorrectQuestionCount.ToString();
            }

            FormPassValue.getScore = studentGetScore;
            FormPassValue.correctCount = studentCorrectQuestionCount;
        }

        /// <summary>
        /// DealWithStudentAnswer
        /// </summary>
        private void DealWithExamResult()
        {
            string isPassed = Constants.EMPTY_STR;
            if (studentGetScore < FormPassValue.passCriteria)
            {
                isPassed = NOPASS;
            }
            else if (studentGetScore >= FormPassValue.passCriteria)
            {
                isPassed = PASS;
            }

            // insert student grade and isPassed
            ExamService.ExamServiceClient examManager = new ExamService.ExamServiceClient();

            //if need to query grade randomly, should insert correct quantity
            examManager.InsertExamResultById(RememberUserParameter.userId, FormPassValue.examId, studentGetScore, isPassed);

            if (FormPassValue.isNoticeStart == 0)
            {
                // update dataGridView dataSource so that avoid student take exam again
                MyExam form = (this.Owner as FormExamList).GetPnlMyExam();

                UserDS.SearchExamDataTable table = examManager.SearchExam(QueryExamState.SortColumn, QueryExamState.SortDirection, form.GetCurrentPage(),
                   form.GetPageSize(), QueryExamState.KeywordState, RememberUserParameter.username);
                form.GetAllExam().GetDgvExamList().DataSource = DataTableUtils.ConvertDataTable(table);
            }

            FormPassValue.isNoticeStart = 0;
        }

        /// <summary>
        /// Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            TimeSpan durationTime = Now - FormPassValue.effectiveTime;
            string tsHour = durationTime.Hours.ToString();
            string tsMin = durationTime.Minutes.ToString();
            string tsSecond = durationTime.Seconds.ToString();
            this.lblTimer.Text = tsHour + COLON + tsMin + COLON + tsSecond;

            //Calculate isOverTime
            TimeSpan tsEndTiem = new TimeSpan(FormPassValue.endTime.Ticks);
            TimeSpan tsNow = new TimeSpan(DateTime.Now.Ticks);
            double timeInterval = tsNow.Subtract(tsEndTiem).TotalSeconds;

            //if over time then auto submit
            if (timeInterval >= 0 && this.pnlAutoResult.Visible == false)
            {
                CalculateResult(true);

                //set exam isfinshed = 1 to flag exam is over
                examManager.UpdateExamAsFinished(FormPassValue.examId);

                //hide exam panel
                this.pnlMainLayout.Visible = false;

                //show result panel
                this.pnlAutoResult.Visible = true;
            }
        }

        //show student exam answer details form
        private void LblViewDetail_Click(object sender, EventArgs e)
        {
            //show result details
            FormPassValue.currentWindowState = this.WindowState;
            FormResultDetails formResultDetails = new FormResultDetails();
            formResultDetails.Show(this.Owner);
            this.Close();
        }

        public void HideAndShow(Label obj, Label opObj)
        {
            foreach(Control con in obj.Parent.Controls)
            {
                if (((Label)con) != obj && ((Label)con) != opObj)
                {
                    if (((Label)con).Tag.Equals(SHOW_FLAG))
                    {
                        ((Label)con).Hide();
                    }
                    else
                    {
                        ((Label)con).Show();
                    }
                }
            }
        }

        private void LblAunselect_Click(object sender, EventArgs e)
        {
            this.lblASelect.Show();
            lblAunselect.Hide();
            HideAndShow(this.lblASelect, lblAunselect);
        }

        private void LblBunselect_Click(object sender, EventArgs e)
        {
            this.lblBSelect.Show();
            this.lblBunselect.Hide();
            HideAndShow(this.lblBSelect, this.lblBunselect);
        }

        private void LblCunselect_Click(object sender, EventArgs e)
        {
            this.lblCSelect.Show();
            lblCunselect.Hide();
            HideAndShow(this.lblCSelect, lblCunselect);
        }

        private void LblDunselect_Click(object sender, EventArgs e)
        {
            this.lblDSelect.Show();
            lblDunselect.Hide();
            HideAndShow(this.lblDSelect, lblDunselect);
        }
    }
}
