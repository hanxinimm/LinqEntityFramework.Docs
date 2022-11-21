using Hunter.EntityFramework;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Threading;

namespace Intro;


[DbContext(DbProvider.SqlServer)]
public partial class BloggingContext : LinqDbContext
{
    //[TIP]All properties or methods must be protected

    // Recommended writing
    protected IDbEntity<Blog> Blogs { get; set; }

    // Compatible writing
    protected DbSet<Blog> CompatiblePosts { get; set; }

    // Custom writing
    protected CustomDbSet<Post> ClassPosts { get; set; }

    // The custom class or interface must inherit from the IDbEntity<TEntity> interface 
    protected ICustomDbSet<Post> InterfacePosts { get; set; }

    [DbFunction(nameof(GetPosts))]
    protected DbSet<GetHostPost> GetPosts(int postType) => default;


    protected override void OnConfiguring(LinqDbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");
    }
}

// Custom entity interface
public interface ICustomDbSet<TEntity> : IDbEntity<TEntity>
{

}

// Custom entity class
public class CustomDbSet<TEntity> : IDbEntity<TEntity>
{

}

//public partial class BloggingContext // : ILinqDbContextQuery<IDbEntityQueryLambdaExpression>, ILinqDbContextExecute<IDbEntityExecuteLambdaExpression>
//{

//    #region LinqDbContextLambdaExpression

//    //public interface IDbEntityQueryLambdaExpression : IDbEngineLambdaExpression
//    //{
//    //    public IDbEntityRelationalQueryLambdaExpression<Post> OldPosts { get; set; }

//    //    public IDbEntityRelationalQueryLambdaExpression<Post> Posts { get; set; }

//    //    public IDbEntityRelationalQueryLambdaExpression<Blog> Blogs { get; set; }

//    //    public IDbEntityRelationalQueryLambdaExpression<GetHostPost> GetPosts(int postType) => default;

//    //}

//    //public interface IDbEntityExecuteLambdaExpression : IDbEngineLambdaExpression
//    //{
//    //    public IDbEntityRelationalExecuteLambdaExpression<Blog> OldPosts { get; set; }

//    //    public IDbEntityRelationalExecuteLambdaExpression<Blog> Posts { get; set; }

//    //    public IDbEntityRelationalExecuteLambdaExpression<Blog> Blogs { get; set; }

//    //}

//    #endregion
//}


public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
    public int Rating { get; set; }
    public List<Post> Posts { get; set; }

    public DateTime ModifyTime { get; set; }
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}

public class GetHostPost
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}