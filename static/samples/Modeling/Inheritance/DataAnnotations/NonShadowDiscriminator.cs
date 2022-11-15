using Hunter.EntityFramework;

namespace EFModeling.Inheritance.DataAnnotations.NonShadowDiscriminator;

public class MyContext : LinqDbContext
{
    public DbSet<Blog> Blogs { get; set; }
}

#region NonShadowDiscriminator
public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }

    [DbDiscriminator]
    [DbAlias("blog_type")]
    [DbMaxLength(200)]
    public string BlogType { get; set; }
}

public class RssBlog : Blog
{
    public string RssUrl { get; set; }
}
#endregion