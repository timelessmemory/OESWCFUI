using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using OesWCFContract;
using OesLogic;
using System.Data;

namespace OesWCFImpl
{
    public class ExamService : IExamService
    {

        public ExamDS.examDataTable getExamById(int id)
        {
            ExamManager examManager = new ExamManager();
            ExamDS.examDataTable dataTable = new ExamDS.examDataTable();
            dataTable.Merge(examManager.getExamById(id));
            return dataTable;
        }

        public int getExamCount(string username, string keyword)
        {
            ExamManager examManager = new ExamManager();
            return examManager.getExamCount(username, keyword);
        }

        public void InsertExanResultById(int userId, int examId, double score, string isPassed)
        {
            ExamManager examManager = new ExamManager();
            examManager.InsertExanResultById(userId, examId, score, isPassed);
        }

        public UserDS.SearchExamDataTable SearchExam(string sortName, string sortDirection, int currentPage, int pageSize, string keyword, string userName)
        {
            ExamManager examManager = new ExamManager();
            UserDS.SearchExamDataTable table = new UserDS.SearchExamDataTable();
            table.Merge(examManager.SearchExam(sortName, sortDirection, currentPage, pageSize, keyword, userName));
            return table;
        }

        public ExamDS.exam_exceptionDataTable GetExceptionOccurTime(int userId, int examId)
        {
            ExamManager examManager = new ExamManager();
            ExamDS.exam_exceptionDataTable table = new ExamDS.exam_exceptionDataTable();
            table.Merge(examManager.GetExceptionOccurTime(userId, examId));
            return table;
        }

        public void InsertExamExceptionTime(int userId, int examId, DateTime dataTime)
        {
            ExamManager examManager = new ExamManager();
            examManager.InsertExamExceptionTime(userId, examId, dataTime);
        }
    }
}
