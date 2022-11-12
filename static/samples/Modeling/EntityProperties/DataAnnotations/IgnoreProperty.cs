using System;
using System.ComponentModel.DataAnnotations.Schema;
using Hunter.EntityFramework;

namespace EFModeling.EntityProperties.DataAnnotations.IgnoreProperty;

internal class MyContext : LinqDbContext
{
    public DbSet<Blog> Blogs { get; set; }
}

#region IgnoreProperty
public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }

    [DbIgnore]
    [NotMapped]
    public DateTime LoadedFromDatabase { get; set; }
}
#endregion