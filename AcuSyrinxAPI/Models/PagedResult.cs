using System.Linq;

namespace AcuSyrinxAPI.Models
{
    public class PagedResult<T>
    {
        public int PageId { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
        public IQueryable<T> Data { get; set; }
    }
}