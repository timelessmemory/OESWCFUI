using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OesDAL.UserDSTableAdapters;
using OesDAL.ExamDSTableAdapters;

namespace OesLogic
{
    public class ExamManager
    {
        /// <summary>
        /// Search exam as some condition
        /// </summary>
        /// <param name="sortName">order by which column</param>
        /// <param name="sortDirection">asc or desc</param>
        /// <param name="currentPage">paginatiion current page</param>
        /// <param name="pageSize">pagination per page size</param>
        /// <param name="keyword">all or unfinsihed or finished</param>
        /// <returns>exam result you query</returns>
        public OesDAL.UserDS.SearchExamDataTable SearchExam(string sortName, string sortDirection, int currentPage, int pageSize, string keyword, string userName) 
        {
            try
            {
                SearchExamTableAdapter searchExamAdapter = new SearchExamTableAdapter();
                //debug default query "admin"
                return searchExamAdapter.GetData(sortName, sortDirection, currentPage, pageSize, userName, keyword);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        //pagination, get total
        public int getExamCount(string username, string keyword)
        {
            SearchExamTableAdapter tableAdapter = new SearchExamTableAdapter();
            int count = Convert.ToInt32(tableAdapter.SearchExamCount(username, keyword, null, null, null));
            return count;
        }

        public OesDAL.ExamDS.examDataTable getExamById(int id)
        {
            examTableAdapter examAdapter = new examTableAdapter();
            return examAdapter.GetExamById(id);
        }

        public void InsertExanResultById(int userId, int examId, double score, string isPassed)
        {
            user_examTableAdapter adapter = new user_examTableAdapter();
            adapter.InsertExamResultByUserIdAndExamId(score, isPassed, userId, examId);
        }

        public OesDAL.ExamDS.exam_exceptionDataTable GetExceptionOccurTime(int userId, int examId)
        {
            exam_exceptionTableAdapter adapter = new exam_exceptionTableAdapter();
            return adapter.GetOccurTime(userId, examId);
        }

        public void InsertExamExceptionTime(int userId, int examId, DateTime dataTime)
        {
            exam_exceptionTableAdapter adapter = new exam_exceptionTableAdapter();
            adapter.InsertExamExceptionTime(userId, examId, dataTime);
        }
    }
}
