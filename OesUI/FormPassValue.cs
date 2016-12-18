using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OesUI.QuestionService;

namespace OesUI
{
    public static class FormPassValue
    {
        public static int examId = 1;
        public static DateTime effectiveTime;
        public static double eachQuestionPoint;
        public static DateTime endTime;
        public static double passCriteria;
        public static string examName;
        public static int duration;
        public static int questionQuantity;
        public static double totalScore;
        public static double getScore;
        public static int correctCount;
        public static List<string> answerList = new List<string>();
        public static List<string> correctAnswerList = new List<string>();
        public static QuestionDS.ExamQuestionDataTable questionTable;
        public static int questionSerial = 1;
        public static int examDetailExamId =1;
        public static string languageState = "zh-CN";
        public static FormWindowState currentWindowState = FormWindowState.Maximized;
        public static int whichRole;
        public static int isNoticeStart = 0;
        public static int isAllowTakeExam = 1;
        public static bool isSendEmail = false;
        public static Form loginForm;
    }
}
