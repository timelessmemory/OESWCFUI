using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using OesUI.Custom;
using OesUI.QuestionService;
using OesUI.utils;

namespace OesUI
{
    public partial class FormResultDetails : Form
    {
        private const string NO = "No";
        private const string MIN = "min";
        private const string EXAM_SCORE = "ExamScore";
        private const string EXAM_RESULT = "ExamResult";
        private const string EXAM_RESULT_FRAG = "ExamResultFrag";
        private const string EXAM_RESULT_FRAGTWO = "ExamResultFragTwo";
        private const string KEY = "Key";
        private QuestionDS.ExamQuestionDataTable questionTable;
        private static List<string> answerList = new List<string>();
        private static List<string> correctAnswerList = new List<string>();
        private Color correctAnswerOptionColor = Color.FromArgb(210, 218, 227);
        private Color formalAnswerOptionColor = Color.White;
        private static int questionCount;
        private int madding = 8;

        public FormResultDetails()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo(FormPassValue.languageState);
            SetResourceCulture();
        }

        private void SetResourceCulture()
        {
            this.lblName.Text = ResourceCulture.GetString(Constants.Exam_Name_Label);
            this.lblEffective.Text = ResourceCulture.GetString(Constants.Effective_Time);
            this.lblDuration.Text = ResourceCulture.GetString(Constants.Duration);
            this.lblQuestion.Text = ResourceCulture.GetString(Constants.Question_Count);
            this.lblId.Text = ResourceCulture.GetString(Constants.ID);
            this.lblTotal.Text = ResourceCulture.GetString(Constants.Total_Score);
            this.lblGetScore.Text = ResourceCulture.GetString(EXAM_SCORE);
            this.lblExamres.Text = ResourceCulture.GetString(EXAM_RESULT);
            this.lblExamScore.Text = ResourceCulture.GetString(EXAM_SCORE);
            this.lblGetScore.Text = ResourceCulture.GetString(EXAM_SCORE);
            this.lbl.Text = ResourceCulture.GetString(EXAM_RESULT_FRAG);
            this.lblFrag.Text = ResourceCulture.GetString(EXAM_RESULT_FRAGTWO);
            this.lblKey.Text = ResourceCulture.GetString(KEY);
        }

        //show result detail
        private void FormResultDetails_Load(object sender, EventArgs e)
        {
            this.WindowState = FormPassValue.currentWindowState;
            this.Owner.Hide();

            //prepare data
            questionCount = FormPassValue.questionQuantity;
            questionTable = FormPassValue.questionTable;
            answerList = FormPassValue.answerList;
            correctAnswerList = FormPassValue.correctAnswerList;

            //fill exam information
            FillData();

            //isCorrectIcon parameter
            int isCorrectIconX = 130;
            int isCorrectIconY = 260;
            int isCorrectIconWidth = 30;
            int isCorrectIconHeight = 30;

            //question serial parameter
            Font questionSerialAndTitleFont = new Font(Constants.ARIAL, 15);
            int questionSerialX = 190;
            int questionSerialY = 260;
            int questionSerialWidth = 30;
            int questionSerialHeight = 25;
            Color fontColor = Color.FromArgb(10, 10, 10);
            Color correctBorderColor = Color.FromArgb(254, 153, 1);
            Color incorrectBorderColor = Color.FromArgb(185, 31, 31);

            //question title parameter
            int questionTitlelblHeight = 30;
            int questionTitlelblWidth = 730;
            int questionTitlelblX = 230;
            int questionTitlelblY = 260;

            //public parameter
            Font answerOptionFont = new Font(Constants.ARIAL, 13.5f);
            int rdoWidth = 25;
            int rdoHeight = 17;
            int answerlblWidth = 700;
            int answerlblHeight = 20;

            //answerA radio position
            int answerArdoX = 190;
            int answerArdoY = 320;

            //answerA item position
            int answerAX = 230;
            int answerAY = 320;

            int answerBrdoX = 190;
            int answerBrdoY = 360;

            int answerBX = 230;
            int answerBY = 360;

            int answerCrdoX = 190;
            int answerCrdoY = 400;

            int answerCX = 230;
            int answerCY = 400;

            int answerDrdoX = 190;
            int answerDrdoY = 440;

            int answerDX = 230;
            int answerDY = 440;

            //question position offset
            int positionYOffset = 240;

            Color optionBgColor = Color.White;
            bool isChecked = false;

            for (int i = 1; i <= questionCount; i++)
            {
                string title = Constants.EMPTY_STR;
                string answerA = Constants.EMPTY_STR;
                string answerB = Constants.EMPTY_STR;
                string answerC = Constants.EMPTY_STR;
                string answerD = Constants.EMPTY_STR;

                var question = from q in questionTable 
                               where Convert.ToInt32((q[NO])) == i 
                               select new 
                               { 
                                   No = (q[NO]), q.title, q.answer_a, q.answer_b, q.answer_c, q.answer_d 
                               };

                foreach(var item in question)
                {
                    title = item.title;
                    answerA = item.answer_a;
                    answerB = item.answer_b;
                    answerC = item.answer_c;
                    answerD = item.answer_d;
                }

                int tmpNum = i - 1;

                if (tmpNum < answerList.Count && answerList[tmpNum].Equals(correctAnswerList[tmpNum]))
                {
                    //correct icon
                    CreateIsCorrectIcon(OesUI.Properties.Resources.ICN_Right_15x15, isCorrectIconWidth, 
                        isCorrectIconHeight, isCorrectIconX, isCorrectIconY);
                    
                    //questionSerial
                    CreateQuestionSerial(questionSerialAndTitleFont, i.ToString(), questionSerialHeight, questionSerialWidth,
                        questionSerialX, questionSerialY, correctBorderColor, fontColor);
                }
                else
                {
                    //inCorrect icon
                    CreateIsCorrectIcon(OesUI.Properties.Resources.ICN_Wrong_15x15, isCorrectIconWidth, 
                        isCorrectIconHeight, isCorrectIconX, isCorrectIconY);

                    //incorrect questionSerial
                    CreateQuestionSerial(questionSerialAndTitleFont, i.ToString(), questionSerialHeight, 
                        questionSerialWidth, questionSerialX, questionSerialY, incorrectBorderColor, fontColor);
                }

                //questionTitle
                CreateQuestionTitle(questionSerialAndTitleFont, title, questionTitlelblHeight, questionTitlelblWidth, 
                    questionTitlelblX, questionTitlelblY);

                //answerARadio
                string tmpCorrectAnswer = correctAnswerList[tmpNum];
                string tmpUserAnswer = Constants.EMPTY_STR;

                if (tmpNum < answerList.Count)
                {
                    tmpUserAnswer = answerList[tmpNum];
                }

                isChecked = ChooseUserAnswerRadio(tmpUserAnswer, Constants.A_OPTION, isChecked);
                CreateAnswerRadio(isChecked, questionSerialAndTitleFont, Constants.A_OPTION, rdoWidth, rdoHeight, answerArdoX, answerArdoY);

                //answerAItem
                optionBgColor = ChooseWhichColor(tmpCorrectAnswer, Constants.A_OPTION, optionBgColor);
                CreateAnswerItem(optionBgColor, answerOptionFont, Constants.A_OPTIONS + answerA, answerlblWidth, answerlblHeight, answerAX, answerAY);

                //answerBRadio
                isChecked = ChooseUserAnswerRadio(tmpUserAnswer, Constants.B_OPTION, isChecked);
                CreateAnswerRadio(isChecked, questionSerialAndTitleFont, Constants.B_OPTION, rdoWidth, rdoHeight, answerBrdoX, answerBrdoY);

                //answerBItem
                optionBgColor = ChooseWhichColor(tmpCorrectAnswer, Constants.B_OPTION, optionBgColor);
                CreateAnswerItem(optionBgColor, answerOptionFont, Constants.B_OPTIONS + answerB, answerlblWidth, answerlblHeight, answerBX, answerBY);

                //answerCRadio
                isChecked = ChooseUserAnswerRadio(tmpUserAnswer, Constants.C_OPTION, isChecked);
                CreateAnswerRadio(isChecked, questionSerialAndTitleFont, Constants.C_OPTION, rdoWidth, rdoHeight, answerCrdoX, answerCrdoY);

                //answerCItem
                optionBgColor = ChooseWhichColor(tmpCorrectAnswer, Constants.C_OPTION, optionBgColor);
                CreateAnswerItem(optionBgColor, answerOptionFont, Constants.C_OPTIONS+ answerC, answerlblWidth, answerlblHeight, answerCX, answerCY);

                //answerDRadio
                isChecked = ChooseUserAnswerRadio(tmpUserAnswer, Constants.D_OPTION, isChecked);
                CreateAnswerRadio(isChecked, questionSerialAndTitleFont, Constants.D_OPTION, rdoWidth, rdoHeight, answerDrdoX, answerDrdoY);

                //answerDItem
                optionBgColor = ChooseWhichColor(tmpCorrectAnswer, Constants.D_OPTION, optionBgColor);
                CreateAnswerItem(optionBgColor, answerOptionFont, Constants.D_OPTIONS + answerD, answerlblWidth, answerlblHeight, answerDX, answerDY);

                //position offset
                isCorrectIconY += positionYOffset;
                questionSerialY += positionYOffset;
                questionTitlelblY += positionYOffset;
                answerArdoY += positionYOffset;
                answerAY += positionYOffset;
                answerBrdoY += positionYOffset;
                answerBY += positionYOffset;
                answerCrdoY += positionYOffset;
                answerCY += positionYOffset;
                answerDrdoY += positionYOffset;
                answerDY += positionYOffset;
            }
        }

        private bool ChooseUserAnswerRadio(string userAnswer, string option, bool isCheck)
        {
            if (userAnswer.Equals(option))
            {
                isCheck = true;
            }
            else
            {
                isCheck = false;
            }
            return isCheck;
        }

        private Color ChooseWhichColor(string correctAnswer, string option, Color origin)
        {
            if (correctAnswer.Equals(option))
            {
                origin = correctAnswerOptionColor;
            }
            else
            {
                origin = formalAnswerOptionColor;
            }
            return origin;
        }

        private void CreateIsCorrectIcon(Image image ,int width, int height, int x, int y)
        {
            Label isCorrectIcon = new Label();
            isCorrectIcon.Image = image;
            isCorrectIcon.AutoSize = false;
            isCorrectIcon.Width = width;
            isCorrectIcon.Height = height;
            Point isCorrectIconLoc = new Point(x, y);
            isCorrectIcon.Location = isCorrectIconLoc;
            this.pnlContainer.Controls.Add(isCorrectIcon);
        }

        private void CreateQuestionSerial(Font font, string text, int height, int width, int x, int y, Color borderColor, Color fontColor)
        {
            QuestionSerial questionSerial = new QuestionSerial();
            questionSerial.BorderColor = borderColor;
            questionSerial.FontColor = fontColor;
            questionSerial.Font = font;
            questionSerial.Text = text;
            questionSerial.Height = height;
            questionSerial.Width = width;
            Point questionSerialLoc = new Point(x, y);
            questionSerial.Location = questionSerialLoc;
            this.pnlContainer.Controls.Add(questionSerial);
        }

        private void CreateQuestionTitle(Font font, string text, int height, int width, int x, int y)
        {
            Label questionTitlelbl = new Label();
            questionTitlelbl.TextAlign = ContentAlignment.MiddleLeft;
            questionTitlelbl.Font = font;
            questionTitlelbl.Text = text;
            questionTitlelbl.AutoSize = false;
            questionTitlelbl.Height = height;
            questionTitlelbl.Width = width;
            Point questionTitlelblLoc = new Point(x, y);
            questionTitlelbl.Location = questionTitlelblLoc;
            this.pnlContainer.Controls.Add(questionTitlelbl);
        }

        private void CreateAnswerRadio(bool isChecked, Font font,string radioText, int radioWidth, int radioHeight, int radioX, int radioY)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Height = radioHeight;
            panel.Width = radioWidth;
            Point answerRadioLoc = new Point(radioX, radioY);
            panel.Location = answerRadioLoc;

            Label icon = new Label();
            icon.Height = radioHeight;
            icon.Width = radioWidth - madding;

            if (isChecked)
            {
                icon.Image = OesUI.Properties.Resources.Selected_png;
            }
            else
            {
                icon.Image = OesUI.Properties.Resources.Unselected_png;
            }

            panel.Controls.Add(icon);
            this.pnlContainer.Controls.Add(panel);

            //RadioButton answerRadio = new RadioButton();
            //answerRadio.Checked = isChecked;
            //answerRadio.Enabled = false;
            //answerRadio.Font = font;
            //answerRadio.Text = radioText;
            //answerRadio.AutoSize = false;
            //answerRadio.Width = radioWidth;
            //answerRadio.Height = radioHeight;
            //Point answerRadioLoc = new Point(radioX, radioY);
            //answerRadio.Location = answerRadioLoc;
            //this.pnlContainer.Controls.Add(answerRadio);
        }

        private void CreateAnswerItem(Color answerBgColor, Font font, string text, int width, int height, int x, int y)
        {
            Label answerItem = new Label();
            answerItem.Font = font;
            answerItem.Text = text;
            answerItem.BackColor = answerBgColor;
            answerItem.AutoSize = true;
            answerItem.Height = height;
            Point answerItemLoc = new Point(x, y);
            answerItem.Location = answerItemLoc;
            this.pnlContainer.Controls.Add(answerItem);
        }

        private void FillData()
        {
            this.lblNameValue.Text = FormPassValue.examName;
            this.lblIdValue.Text = FormPassValue.examId.ToString();
            this.lblEffectiveTimeValue.Text = FormPassValue.effectiveTime.ToString();
            this.lblTotalScore.Text = FormPassValue.getScore.ToString();
            this.lblTotalScoreValue.Text = FormPassValue.totalScore.ToString();
            this.lblDurationvalue.Text = FormPassValue.duration + ResourceCulture.GetString(MIN);
            this.lblGetScoreValue.Text = FormPassValue.getScore.ToString();
            this.lblcorrectCount.Text = FormPassValue.correctCount.ToString();
            this.lblQuestionCountValue.Text = FormPassValue.questionQuantity.ToString();
        }
    }
}
