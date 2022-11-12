using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

    [Required]
    public string Url { get; set; }
}