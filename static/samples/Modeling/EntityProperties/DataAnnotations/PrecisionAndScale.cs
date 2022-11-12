using Hunter.EntityFramework;
using System;

namespace EFModeling.EntityProperties.DataAnnotations.PrecisionAndScale;

internal class MyContext : LinqDbContext
{
    public DbSet<Blog> Blogs { get; set; }
}

#region PrecisionAndScale
public class Blog
{
    public int BlogId { get; set; }
    [DbPrecision(14, 2)]
    public decimal Score { get; set; }
    [DbPrecision(3)]
    public DateTime LastUpdated { get; set; }
}
#endregion