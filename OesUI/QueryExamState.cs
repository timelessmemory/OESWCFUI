
namespace OesUI
{
    public static class QueryExamState
    {
        private static string keywordState = "all";
        private static string sortColumn = "id";
        private static string sortDirection = "asc";

        public static string KeywordState
        {
            get { return QueryExamState.keywordState; }
            set { QueryExamState.keywordState = value; }
        }

        public static string SortColumn
        {
            get { return QueryExamState.sortColumn; }
            set { QueryExamState.sortColumn = value; }
        }

        public static string SortDirection
        {
            get { return QueryExamState.sortDirection; }
            set { QueryExamState.sortDirection = value; }
        }
    }
}
