using System;
using System.Linq;

namespace EFQuerying.Pagination;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new BloggingContext())
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        using (var context = new BloggingContext())
        {
            #region OffsetPagination
            var position = 20;
            var nextPage = context.Query(linq => linq.Posts
                .Select()
                .OrderBy(b => b.PostId)
                .Paging(position, 10).ToEnumerable());
            #endregion
        }

        using (var context = new BloggingContext())
        {
            #region KeySetPagination
            var lastId = 55;

            var nextPage = context.Query(linq => linq.Posts
                .Select(10)
                .Where(b => b.PostId > lastId)
                .OrderBy(b => b.PostId)
                .ToList());
            #endregion
        }

        using (var context = new BloggingContext())
        {
            #region KeySetPaginationWithMultipleKeys
            var lastDate = new DateTime(2020, 1, 1);
            var lastId = 55;

            var topPage = context.Query(linq => linq.Posts
                .Select(10)
                .Where(b => b.Date > lastDate || (b.Date == lastDate && b.PostId > lastId))
                //.OrderBy(b => new { b.Date, b.PostId })
                .OrderBy(b => new { b.Date, b.PostId })
                .ToList());
            #endregion
        }
    }
}