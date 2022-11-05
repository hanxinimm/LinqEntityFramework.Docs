using Hunter.EntityFramework;
using System;
using System.Linq;

using var db = new BloggingContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");

// Create
Console.WriteLine("Inserting a new blog");
db.Execute(dbEngine => dbEngine.Insert<Blog>().Value(new Blog { Url = "http://blogs.msdn.com/adonet" }));
db.SaveChanges();

// Read
Console.WriteLine("Querying for a blog");
var blog = db.Query(dbEngine => dbEngine.Select<Blog>()
    .Order(b => new IOrderRule[] { new AscendingRule((b.Posts)) })
    .First());

// Update
Console.WriteLine("Updating the blog and adding a post");

blog.Url = "https://devblogs.microsoft.com/dotnet";
blog.Posts.Add(
    new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });

//TODO:考虑这种情况是否优化代码结构
db.Execute(dbEngine => dbEngine.Update<Blog>().Value(blog).WhereByPrimaryKey());


db.SaveChanges();

// Delete
Console.WriteLine("Delete the blog");
db.Execute(dbEngine => dbEngine.Delete<Blog>().Where(blog));

db.SaveChanges();