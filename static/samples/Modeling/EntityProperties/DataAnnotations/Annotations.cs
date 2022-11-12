using Hunter.EntityFramework;

namespace EFModeling.EntityProperties.DataAnnotations.Annotations;

internal class MyContext : LinqDbContext
{
    public DbEntity<Blog> Blogs { get; set; }
}

[DbEntity("Blogs")]
public class Blog
{
    public int BlogId { get; set; }

    [DbRequired]
    public string Url { get; set; }
}