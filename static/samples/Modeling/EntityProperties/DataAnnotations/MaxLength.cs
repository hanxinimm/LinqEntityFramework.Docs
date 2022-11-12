using Hunter.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace EFModeling.EntityProperties.DataAnnotations.MaxLength;

internal class MyContext : LinqDbContext
{
    public DbSet<Blog> Blogs { get; set; }
}

#region MaxLength
public class Blog
{
    public int BlogId { get; set; }

    [DbMaxLength(500)]
    public string Url { get; set; }
}
#endregion