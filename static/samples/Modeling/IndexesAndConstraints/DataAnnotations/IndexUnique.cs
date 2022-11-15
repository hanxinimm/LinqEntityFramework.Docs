﻿using Hunter.EntityFramework;

namespace EFModeling.IndexesAndConstraints.DataAnnotations.IndexUnique;

internal class MyContext : LinqDbContext
{
    public DbSet<Blog> Blogs { get; set; }
}

#region IndexUnique
public class Blog
{
    public int BlogId { get; set; }

    [DbIndex(nameof(Url), IsUnique = true)]

    public string Url { get; set; }
}
#endregion