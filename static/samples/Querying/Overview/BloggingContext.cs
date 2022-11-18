using Hunter.EntityFramework;

namespace EFQuerying.Overview;

[DbContext(DbProvider.Sqlite)]
public partial class BloggingContext : LinqDbContext
{
    protected DbSet<Blog> Blogs { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Blog>()
    //        .HasData(
    //            new Blog { BlogId = 1, Url = @"https://devblogs.microsoft.com/dotnet", Rating = 5 },
    //            new Blog { BlogId = 2, Url = @"https://mytravelblog.com/", Rating = 4 });
    //}

    protected override void OnConfiguring(LinqDbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(
            @"Server=(localdb)\mssqllocaldb;Database=EFQuerying.Overview;Trusted_Connection=True");
    }
}