using Hunter.EntityFramework;

namespace EFModeling.IndexesAndConstraints.DataAnnotations.IndexDescending;

internal class MyContext : LinqDbContext
{
    public DbSet<Blog> Blogs { get; set; }
}

#region IndexDescending
public class Blog
{
    public int BlogId { get; set; }

    [DbIndex(nameof(Url))]
    public string Url { get; set; }

    [DbIndex(nameof(Rating))]
    public int Rating { get; set; }
}
#endregion
