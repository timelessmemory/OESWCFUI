using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OesDAL.QuestionDSTableAdapters;

namespace OesUI.test
{
    [TestFixture]
    public class DALTest
    {
        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {

        }

        [TestCase]
        public void TestExamAnswerDetail()
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
