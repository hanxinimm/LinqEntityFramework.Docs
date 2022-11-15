using Hunter.EntityFramework;

namespace EFModeling.IndexesAndConstraints.DataAnnotations.IndexDescendingAscending;

internal class MyContext : LinqDbContext
{
    public DbSet<Blog> Blogs { get; set; }
}

#region IndexDescendingAscending
public class Blog
{
    public int BlogId { get; set; }

    [DbIndexAscending(nameof(Url))]
    public string Url { get; set; }

    [DbIndexDescending(nameof(Rating))]
    public int Rating { get; set; }
}
#endregion
