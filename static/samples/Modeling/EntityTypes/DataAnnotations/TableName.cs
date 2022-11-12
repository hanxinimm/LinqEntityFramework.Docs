using Hunter.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFModeling.EntityTypes.DataAnnotations.TableName;

internal class MyContext : LinqDbContext
{
    public DbEntity<Blog> Blogs { get; set; }
}

#region TableName
[DbEntity("blogs")] // Recommended writing
[Table("blogs")] // Compatible writing
public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
}

#endregion