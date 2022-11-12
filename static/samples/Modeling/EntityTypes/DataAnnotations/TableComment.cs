using Hunter.EntityFramework;

namespace EFModeling.EntityTypes.DataAnnotations.TableComment;

internal class MyContext : LinqDbContext
{
    public DbSet<Blog> Blogs { get; set; }
}

#region TableComment
[DbComment("Blogs managed on the website")]
public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
}
#endregion