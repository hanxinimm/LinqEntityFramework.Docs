using Hunter.EntityFramework;
using NetTopologySuite.Geometries;

namespace EFQuerying.Tags;

[DbContext(DbProvider.SqlServer)]
public partial class SpatialContext : LinqDbContext
{
    protected DbSet<Person> People { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Person>(
    //        b =>
    //        {
    //            b.Property(e => e.Location).HasColumnType("geometry");

    //            b.HasData(
    //                new Person { Id = 1, Location = new Point(0, 1) },
    //                new Person { Id = 2, Location = new Point(2, 1) },
    //                new Person { Id = 3, Location = new Point(4, 5) });
    //        });
    //}

    protected override void OnConfiguring(LinqDbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=(localdb)\mssqllocaldb;Database=EFQuerying.Tags;Trusted_Connection=True");
    }
}