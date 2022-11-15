using Hunter.EntityFramework;

namespace EFModeling.Inheritance.DataAnnotations.DiscriminatorConfiguration;

public class MyContext : LinqDbContext
{
    public DbEntity<Blog> Blogs { get; set; }
}

#region DiscriminatorConfiguration
public enum BlogType
{
    Blog,
    RssBlog
}

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }

    [DbDiscriminator]
    protected virtual BlogType Type => BlogType.Blog;
}

public class RssBlog : Blog
{
    public string RssUrl { get; set; }

    protected override BlogType Type => BlogType.RssBlog;
}
#endregion