using Hunter.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFModeling.EntityTypes.DataAnnotations.TableNameAndSchema;

internal class MyContext : LinqDbContext
{
    public DbEntity<Blog> Blogs { get; set; }
}

#region TableNameAndSchema

[DbEntity("blogs", "blogging")] // Recommended writing
[Table("blogs", Schema = "blogging")] // Compatible writing
public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
}

[DbEntity("blogging.blogs")] // Combined  writing
public class Blogging_Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
}

[DbEntity("blogs", default)] // Default Schema writing
public class Default_Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
}
#endregion