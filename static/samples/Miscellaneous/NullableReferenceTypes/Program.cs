using System;
using System.Linq;

namespace NullableReferenceTypes
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            using (var context = new NullableReferenceTypesContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                context.Execute(linq => linq.Insert(new Customer("John", "Doe")));

                context.Execute(linq => linq.Insert(
                    new Order
                    {
                        ShippingAddress = new Address("London", "Downing"),
                        Product = new Product("Cooking stove"),
                        OptionalInfo = new OptionalOrderInfo("Some additional info")
                        {
                            ExtraAdditionalInfo = new ExtraOptionalOrderInfo("Some extra additional info")
                        }
                    }));

                context.SaveChanges();
            }

            using (var context = new NullableReferenceTypesContext())
            {
                var john = context.Query(linq=>linq.Select<Customer>().Where(c => c.FirstName == "John").First());
                Console.WriteLine("John's last name: " + john.LastName);

                #region Including
                var order = context.Query(linq => linq.Select<Order>()
                    //TODO:自动识别可空类型的判断
                    //.Where(o => o.OptionalInfo != null && o.OptionalInfo.ExtraAdditionalInfo != null)
                    .Where(o => o.OptionalInfo?.ExtraAdditionalInfo != null)
                    .Single());
                #endregion

                // The following would be a programming bug: we forgot to include ShippingAddress above. It would throw InvalidOperationException.
                // Console.WriteLine(order.ShippingAddress.City);
                // The following would be a programming bug: we forgot to include Product above; will throw NullReferenceException. It would throw NullReferenceException.
                // Console.WriteLine(order.Product.Name);

                #region Navigating
                Console.WriteLine(order.OptionalInfo!.ExtraAdditionalInfo!.SomeExtraAdditionalInfo);
                #endregion
            }
        }
    }
}
