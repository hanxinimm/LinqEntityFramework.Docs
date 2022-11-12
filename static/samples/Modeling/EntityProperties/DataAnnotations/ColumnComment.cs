using Hunter.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace EFModeling.EntityProperties.DataAnnotations.ColumnComment;

internal class MyContext : LinqDbContext
{
    public DbSet<Blog> Blogs { get; set; }
}

#region ColumnComment
public class Blog
{
    [DbComment("The Id of the blog")]

    public int BlogId { get; set; }

    [Comment("The URL of the blog")]
    public string Url { get; set; }
}
#endregion