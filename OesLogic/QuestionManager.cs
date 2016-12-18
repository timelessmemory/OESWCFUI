using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OesDAL;
using OesDAL.QuestionDSTableAdapters;
namespace OesLogic
{
    public class QuestionManager
    {
        public OesDAL.QuestionDS.ExamQuestionDataTable FindQuestionByExamId(int? id) 
        {
            ExamQuestionTableAdapter questionAdapter = new ExamQuestionTableAdapter();
            return questionAdapter.FindQuestionByExamId(id);
        }

        //get question total
        public int? QueryQuestionCount(int id)
        {
            questionTableAdapter questionAdapter = new questionTableAdapter();
            return questionAdapter.QueryQuestionCount(id);
        }

        public int QueryHaveAnsweredQuestionNumber(int userId, int examId)
        {
            exam_answer_detailTableAdapter detailAdapter = new exam_answer_detailTableAdapter();
            return Convert.ToInt32(detailAdapter.QueryHaveAnsweredQuestionNumber(userId, examId));
        }

        public QuestionDS.exam_answer_detailDataTable FindUserAnswer(int userId, int examId)
        {
            exam_answer_detailTableAdapter adapter = new exam_answer_detailTableAdapter();
            return adapter.FindUserAnswer(userId, examId);
        }

        public void InsertUserAnswer(int userId, int examId, int questionId, string userAnswer)
        {
            exam_answer_detailTableAdapter adapter = new exam_answer_detailTableAdapter();
            adapter.InsertUserAnswer(userId, examId, questionId, userAnswer);
        }
    }
}
