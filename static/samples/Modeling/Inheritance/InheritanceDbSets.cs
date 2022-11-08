using Microsoft.EntityFrameworkCore;

namespace EFModeling.Inheritance.InheritanceDbSets;

#region InheritanceDbSets
internal class MyContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<RssBlog> RssBlogs { get; set; }
}

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }

    //TODO:Discriminator 属性
    protected string BlogType { get; set; }
}

public class RssBlog : Blog
{
    public string RssUrl { get; set; }
}
#endregion