using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using OesWCFContract;
using OesLogic;

namespace OesWCFImpl
{
    public class QuestionService : IQuestionService
    {
        public QuestionDS.ExamQuestionDataTable FindQuestionByExamId(int? id)
        {
            QuestionManager manager = new QuestionManager();
            QuestionDS.ExamQuestionDataTable table = new QuestionDS.ExamQuestionDataTable();
            table.Merge(manager.FindQuestionByExamId(id));
            return table;
        }

        public int? QueryQuestionCount(int id)
        {
            QuestionManager manager = new QuestionManager();
            return manager.QueryQuestionCount(id);
        }

        public int QueryHaveAnsweredQuestionNumber(int userId, int examId)
        {
            QuestionManager manager = new QuestionManager();
            return manager.QueryHaveAnsweredQuestionNumber(userId, examId);
        }

        public QuestionDS.exam_answer_detailDataTable FindUserAnswer(int userId, int examId)
        {
            QuestionManager manager = new QuestionManager();
            QuestionDS.exam_answer_detailDataTable table = new QuestionDS.exam_answer_detailDataTable();
            table.Merge(manager.FindUserAnswer(userId, examId));
            return table;
        }

        public void InsertUserAnswer(int userId, int examId, int questionId, string userAnswer)
        {
            QuestionManager manager = new QuestionManager();
            manager.InsertUserAnswer(userId, examId, questionId, userAnswer);
        }
    }
}
