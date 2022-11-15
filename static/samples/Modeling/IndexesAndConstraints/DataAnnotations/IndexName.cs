using Hunter.EntityFramework;

namespace EFModeling.IndexesAndConstraints.DataAnnotations.IndexName;

internal class MyContext : LinqDbContext
{
    public DbSet<Blog> Blogs { get; set; }
}

#region IndexName
public class Blog
{
    public int BlogId { get; set; }

    [DbIndex("Index_Url")]
    public string Url { get; set; }
}
#endregion