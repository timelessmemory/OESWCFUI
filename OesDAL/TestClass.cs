using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OesDAL.QuestionDSTableAdapters;
using System.Collections;
using OesDAL.UserDSTableAdapters;
using OesDAL.ExamDSTableAdapters;

namespace OesDAL
{
    public class TestClass
    {
        public static void Main(string[] args)
        {
            exam_answer_detailTableAdapter adapter = new exam_answer_detailTableAdapter();
            OesDAL.QuestionDS.exam_answer_detailDataTable tableAdapter = adapter.FindUserAnswer(2, 1);
            var rs = from s in tableAdapter select new { s.user_answer };
            foreach (var item in rs)
            {
                Console.WriteLine(item.user_answer);
            }
        }
    }
}
