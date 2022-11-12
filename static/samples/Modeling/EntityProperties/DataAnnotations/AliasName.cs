using Hunter.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFModeling.EntityProperties.DataAnnotations.ColumnName;

internal class MyContext : LinqDbContext
{
    public DbSet<Blog> Blogs { get; set; }
}

#region AliasName
public class Blog
{
    [DbAlias("blog_id")]
    public int BlogId { get; set; }

    [Column("blog_url")]
    public string Url { get; set; }
}
#endregion