namespace SmartSchool.WebAPI.Helpers
{
    public class PaginationHeader
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int ItemPerPage { get; set; }
        public int TotalItems { get; set; }
        public PaginationHeader(int currentPage, int totalPages, int itemPerPage, int totalItems)
        {
            this.CurrentPage = currentPage;
            this.TotalPages = totalPages;
            this.ItemPerPage = itemPerPage;
            this.TotalItems = totalItems;

        }
        
    }
}