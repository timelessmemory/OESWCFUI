namespace OesUI
{
    public static class ExamDetailState
    {
        private static string sortColumn = "name";
        private static string sortDirection = "asc";

        public static string SortColumn
        {
            get { return ExamDetailState.sortColumn; }
            set { ExamDetailState.sortColumn = value; }
        }

        public static string SortDirection
        {
            get { return ExamDetailState.sortDirection; }
            set { ExamDetailState.sortDirection = value; }
        }
    }
}
