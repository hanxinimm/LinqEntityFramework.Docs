using Hunter.EntityFramework;

namespace EFModeling.Inheritance.DataAnnotations.DiscriminatorPropertyConfiguration;

public class MyContext : LinqDbContext
{
    public DbSet<Blog> Blogs { get; set; }
}
#region DiscriminatorPropertyConfiguration
public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }

    [DbDiscriminator]
    [DbMaxLength(500)]
    public string BlogType { get; set; }
}

public class RssBlog : Blog
{
    public string RssUrl { get; set; }
}
#endregion