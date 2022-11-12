using Hunter.EntityFramework;

namespace EFModeling.EntityTypes.DataAnnotations.ViewNameAndSchema;

internal class MyContext : LinqDbContext
{
    public DbView<Blog> Blogs { get; set; }
}

[DbView("blogsView", "blogging")]
public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
}