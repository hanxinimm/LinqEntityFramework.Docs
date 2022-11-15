using System.ComponentModel.DataAnnotations;
using Hunter.EntityFramework;

namespace EFModeling.Keys.DataAnnotations.KeySingle;

internal class MyContext : LinqDbContext
{
    public DbSet<Car> Cars { get; set; }
}

#region KeySingle
internal class Car
{
    [Key]
    [DbKey]
    public string LicensePlate { get; set; }

    public string Make { get; set; }
    public string Model { get; set; }
}
#endregion