using System.Collections.Generic;
using System.Linq;
using cloudscribe.Pagination.Models;

namespace Library.Utility
{
    public class PaginateResult
    {
        public static PagedResult<T> PageResults<T>(List<T> dataSource, int pageNumber, int pageSize) where T : class
        {
            var itemsToBeSkipped = (pageSize * pageNumber) - pageSize;
            var query = dataSource.Skip(itemsToBeSkipped).Take(pageSize);

            return new PagedResult<T>()
            {
                Data = query.ToList(),
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalItems = dataSource.Count

            };
        }
    }
}
