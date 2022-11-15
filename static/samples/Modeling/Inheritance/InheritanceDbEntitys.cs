using Hunter.EntityFramework;

namespace EFModeling.Inheritance.InheritanceDbEntitys;

#region InheritanceDbEntitys
internal class MyContext : LinqDbContext
{
    public DbEntity<Blog> Blogs { get; set; }
    public DbEntity<RssBlog> RssBlogs { get; set; }
}

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }

    [DbDiscriminator]
    protected virtual string BlogType => nameof(Blog);
}

public class RssBlog : Blog
{
    public string RssUrl { get; set; }

    protected override string BlogType => nameof(RssBlog);

}
#endregion