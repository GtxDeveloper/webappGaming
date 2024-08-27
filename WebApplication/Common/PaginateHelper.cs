namespace WebApplication.Common
{
    public class PaginateHelper
    {
        public int CountPosts { get; set; }
        public int PostsPerPage { get; set; } = 4;
        public int CountPages { get; set; }
        public int IndexCurrentPage { get; set; } = 1;
    }
}
