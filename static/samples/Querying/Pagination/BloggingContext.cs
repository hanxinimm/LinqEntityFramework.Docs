using Hunter.EntityFramework;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFQuerying.Pagination;

[DbContext(DbProvider.SqlServer)]
public partial class BloggingContext : LinqDbContext
{
    protected DbSet<Blog> Blogs { get; set; }
    protected DbSet<Post> Posts { get; set; }

    #region SimpleLogging
    protected override void OnConfiguring(LinqDbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True")
            .LogTo(Console.WriteLine, LogLevel.Information);
    }
    #endregion

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Post>().HasIndex(p => p.Title);
    //}
}

public partial class BloggingContext
{
    public IEnumerable<TResult> Query<TResult>(Func<IDbContextQueryLambdaExpression, IDbQueryCollectionExpression<TResult>> linqExpression, ICallerLineNumberPlaceholder? placeholder = default, [CallerLineNumber] int callerLineNumber = 0)
    {
        return Query<IEnumerable<TResult>>(linqExpression.Method, linqExpression.Target, callerLineNumber);
    }
}

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
    public int Rating { get; set; }
    public List<Post> Posts { get; set; }
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}