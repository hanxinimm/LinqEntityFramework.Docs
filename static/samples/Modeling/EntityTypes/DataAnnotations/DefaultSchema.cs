using Hunter.EntityFramework;

namespace EFModeling.EntityTypes.DataAnnotations.DefaultSchema;

internal class MyContext : LinqDbContext
{
    public DbBlogging<Blog> Blogs { get; set; }
}

[DbSchema("blogging")]
public class DbBlogging<TEntity> : IDbEntity<TEntity>
{

}

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
}