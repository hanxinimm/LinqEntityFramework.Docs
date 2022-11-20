using System;
using System.Linq;

namespace EFQuerying.Overview;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new BloggingContext())
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        #region LoadingAllData
        using (var context = new BloggingContext())
        {
            var blogs = context.Query(linq => linq.Blogs.Select().ToList());
        }
        #endregion

        #region LoadingSingleEntity
        using (var context = new BloggingContext())
        {
            var blog = context.Query(linq => linq.Blogs
                .Select(b => b.BlogId == 1).Single());
        }
        #endregion

        #region Filtering
        using (var context = new BloggingContext())
        {
            var blogs = context.Query(linq => linq.Blogs
            .Select().Where(b => b.Url.Contains("dotnet"))
                .ToList());
        }
        #endregion
    }
}