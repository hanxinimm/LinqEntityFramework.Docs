using System.ComponentModel.DataAnnotations;
using Hunter.EntityFramework;

namespace EFModeling.EntityProperties.DataAnnotations.Required;

internal class MyContext : LinqDbContext
{
    public DbSet<Blog> Blogs { get; set; }
}

#region Required
public class Blog
{
    public int BlogId { get; set; }

    [DbRequired]
    [Required]
    public string Url { get; set; }
}
#endregion