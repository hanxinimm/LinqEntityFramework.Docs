using Hunter.EntityFramework;

namespace EFModeling.IndexesAndConstraints.DataAnnotations.IndexComposite;

internal class MyContext : LinqDbContext
{
    public DbSet<Person> People { get; set; }
}

#region Composite
public class Person
{
    public int PersonId { get; set; }

    [DbIndex(nameof(FirstName))]
    public string FirstName { get; set; }

    [DbIndex(nameof(LastName))]
    public string LastName { get; set; }
}
#endregion