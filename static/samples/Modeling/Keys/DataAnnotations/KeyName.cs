using Hunter.EntityFramework;

namespace EFModeling.Keys.DataAnnotations.KeyName;

internal class MyContext : LinqDbContext
{
    public DbSet<Blog> Blogs { get; set; }
}

#region KeyName

public class Blog
{

    [DbKey("PrimaryKey_BlogId")]
    public int BlogId { get; set; }
    public string Url { get; set; }

}

#endregion