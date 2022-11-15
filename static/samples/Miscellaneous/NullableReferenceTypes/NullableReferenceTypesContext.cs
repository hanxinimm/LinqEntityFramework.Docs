using Hunter.EntityFramework;
using Hunter.EntityFramework.Abstractions;

namespace NullableReferenceTypes
{
    #region Context
    public class NullableReferenceTypesContext : LinqAgileDbContext
    {
        //No need to register them
        //public DbSet<Customer> Customers => Set<Customer>();
        //public DbSet<Order> Orders => Set<Order>();

        protected override void OnConfiguring(LinqDbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseSqlServer(
                    @"Server=(localdb)\mssqllocaldb;Database=EFNullableReferenceTypes;Trusted_Connection=True");
    }
    #endregion
}
