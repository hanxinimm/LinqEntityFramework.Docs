using Hunter.EntityFramework;

namespace EFModeling.IndexesAndConstraints.DataAnnotations.Index;

internal class MyContext : LinqDbContext
{
    public DbSet<Blog> Blogs { get; set; }
}

#region Index

public class Blog
{
    public int BlogId { get; set; }

    [DbIndex(nameof(Url))]
    public string Url { get; set; }
}
#endregion