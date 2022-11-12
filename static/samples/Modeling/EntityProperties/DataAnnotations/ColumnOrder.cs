using Hunter.EntityFramework;

namespace EFModeling.EntityProperties.DataAnnotations.ColumnOrder;

internal class MyContext : LinqDbContext
{
    public DbSet<Employee> Employees { get; set; }
}

#region snippet_ColumnAttribute
public class EntityBase
{
    public int Id { get; set; }
}

public class PersonBase : EntityBase
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
}

public class Employee : PersonBase
{
    public string Department { get; set; }
    public decimal AnnualSalary { get; set; }
}
#endregion