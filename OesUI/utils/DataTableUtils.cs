using System;
using System.Data;
using OesUI.ExamService;

namespace OesUI.utils
{
    public static class DataTableUtils
    {
        private static string tableName = "SearchExamDataTable";
        private static string noColumn = "No";
        private static string nameColumn = "Name";
        private static string idColumn = "ID";
        private static string effectiveColumn = "Effective Time";
        private static string duration = "Duration";
        private static string passCriteria = "Pass Criteria";
        private static string totalScore = "Exam/TotalScore";
        private static string operation = "Operation";
        private static string systemInt = "System.Int32";
        private static string systemString = "System.String";
        private static string systemDateTime = "System.DateTime";

        public static DataTable ConvertDataTable(UserDS.SearchExamDataTable table)
        {
            var tmpTable = from t in table
                           select new
                           {
                               t.No,
                               t.exam_name,
                               t.id,
                               t.effective_time,
                               t.duration,
                               t.pass_criteria,
                               t.score,
                               t.total_score,
                               t.operation
                           };

            DataTable tblDatas = new DataTable(tableName);
            DataColumn dc = null;
            dc = tblDatas.Columns.Add(noColumn, Type.GetType(systemInt));
            dc = tblDatas.Columns.Add(nameColumn, Type.GetType(systemString));
            dc = tblDatas.Columns.Add(idColumn, Type.GetType(systemInt));
            dc = tblDatas.Columns.Add(effectiveColumn, Type.GetType(systemDateTime));
            dc = tblDatas.Columns.Add(duration, Type.GetType(systemInt));
            dc = tblDatas.Columns.Add(passCriteria, Type.GetType(systemString));
            dc = tblDatas.Columns.Add(totalScore, Type.GetType(systemString));
            dc = tblDatas.Columns.Add(operation, Type.GetType(systemString));

            foreach (var item in tmpTable)
            {
                DataRow newRow = tblDatas.NewRow();
                newRow[noColumn] = item.No;
                newRow[nameColumn] = item.exam_name;
                newRow[idColumn] = item.id;
                newRow[effectiveColumn] = item.effective_time;
                newRow[duration] = item.duration;
                newRow[passCriteria] = item.pass_criteria.ToString();
                if (item.score == -1)
                {
                    newRow[totalScore] = "-/" + item.total_score;
                }
                else
                {
                    newRow[totalScore] = item.score + "/" + item.total_score;
                }
                newRow[operation] = item.operation;
                tblDatas.Rows.Add(newRow);
            }

            return tblDatas;
        }
    }
}
