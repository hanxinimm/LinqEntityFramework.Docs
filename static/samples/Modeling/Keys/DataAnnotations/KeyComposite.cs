using Hunter.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace EFModeling.Keys.DataAnnotations.KeyComposite;

internal class MyContext : LinqDbContext
{
    public DbSet<Car> Cars { get; set; }
}

#region KeyComposite
internal class Car
{
    [DbKey]
    public string LicensePlate { get; set; }

    [DbKey]
    public string Make { get; set; }
    public string Model { get; set; }
}
#endregion