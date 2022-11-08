﻿using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EFModeling.Keys.DataAnnotations.KeySingle;

internal class MyContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
}

#region KeyComposite
internal class Car
{
    [Key]
    public string LicensePlate { get; set; }

    [Key]
    public string Make { get; set; }
    public string Model { get; set; }
}
#endregion