using Hunter.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFModeling.EntityProperties.DataAnnotations.ColumnDataType;

internal class MyContext : LinqDbContext
{
    public DbSet<Blog> Blogs { get; set; }
}

#region ColumnDataType
public class Blog
{
    public int BlogId { get; set; }

    [Column(TypeName = "varchar(200)")]
    [DbMaxLength(200)]
    public string Url { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    [DbPrecision(15, 2)]
    public decimal Rating { get; set; }
}
#endregion