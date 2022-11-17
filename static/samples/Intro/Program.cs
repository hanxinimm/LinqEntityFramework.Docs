using Hunter.EntityFramework;
using System;
using System.Linq;

namespace Intro;

internal class Program
{
    private static void Main()
    {
        using (var db = new BloggingContext())
        {
            db.Query(dbContext => dbContext.Blogs.Select().SingleOrDefault());

            db.Query(dbContext => dbContext.ClassPosts.Select(10).FieldValue(v => v.PostId));

            db.Query(dbContext => dbContext.GetPosts(1).Select().ToEnumerable());

        }

        #region Querying

        using (var db = new BloggingContext())
        {
            var blogs1 = db.Query(dbContext => dbContext.Blogs.Select(10)
                .Where(b => b.Rating > 3)
                .OrderBy(b => b.Url)
                .ToList());

            var blogs2 = db.Query(dbContext => dbContext.Blogs.Select()
                .Where(b => b.Rating > 3)
                .OrderBy(b => new { b.BlogId, b.Url })
                .ToList());
        }

        #endregion

        #region SavingData

        using (var db = new BloggingContext())
        {
            var blog = new Blog { Url = "http://sample.com" };

            db.Execute(dbContext => dbContext.Blogs.Insert(blog));
            db.Execute(dbContext => dbContext.Blogs.Insert().Value(blog));

            db.Execute(dbContext => dbContext.Blogs.InsertOrIgnore(blog).Where(v => v.BlogId == 1));
            db.Execute(dbContext => dbContext.Blogs.InsertOrIgnore().Value(blog).Where(v => v.BlogId == 1));


            db.Execute(dbContext => dbContext.Blogs.InsertOrUpdate(blog).Where(v => v.BlogId == 1));
            db.Execute(dbContext => dbContext.Blogs.InsertOrUpdate().Value(blog).Where(v => v.BlogId == 1));


            db.Execute(dbContext => dbContext.Blogs.InsertOrUpdate().InsertValue(blog).UpdateValue(blog).Where(v => v.BlogId == 1));

            db.Execute(dbContext => dbContext.Blogs.InsertOrUpdate().InsertValue(blog).UpdateValue(blog, v => v.ModifyTime = DateTime.Now).Where(v => v.BlogId == 1));

            db.Execute(dbContext => dbContext.Blogs.InsertOrUpdate().InsertValue(blog).UpdateSet(v => v.ModifyTime = DateTime.Now).Where(v => v.BlogId == 1));



            db.Execute(dbContext => dbContext.Blogs.Update(blog).Where(v => v.BlogId == 1));
            db.Execute(dbContext => dbContext.Blogs.Update(blog).Where(v => v.BlogId == 1));
            db.Execute(dbContext => dbContext.Blogs.Update().Value(blog).Where(v => v.BlogId == 1));


            db.Execute(dbContext => dbContext.Blogs.Set(v => v.Url = string.Empty).Where(v => v.BlogId == 1));
            db.Execute(dbContext => dbContext.Blogs.Update().Set(v => v.Url = string.Empty).Where(v => v.BlogId == 1));


            db.Execute(dbContext => dbContext.Blogs.DeleteByPrimaryKey(blog));
            db.Execute(dbContext => dbContext.Blogs.Delete(v => v.BlogId == 1));

            db.Execute(dbContext => dbContext.Blogs.Delete(blog).WhereByPrimaryKey());


            db.SaveChanges();
        }

        #endregion
    }
}