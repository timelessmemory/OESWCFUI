
namespace OesUI
{
    public static class TeacherQueryExamListState
    {
        private static string sortColumn = "id";
        private static string sortDirection = "asc";

        public static string SortColumn
        {
            get { return TeacherQueryExamListState.sortColumn; }
            set { TeacherQueryExamListState.sortColumn = value; }
        }

        public static string SortDirection
        {
            get { return TeacherQueryExamListState.sortDirection; }
            set { TeacherQueryExamListState.sortDirection = value; }
        }
    }
}
