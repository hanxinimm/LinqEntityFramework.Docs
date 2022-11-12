using Hunter.EntityFramework;

namespace EFModeling.EntityProperties.DataAnnotations.Unicode;

internal class MyContext : LinqDbContext
{
    public DbSet<Book> Books { get; set; }
}

#region Unicode
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }

    [DbUnicode(false)]
    [DbMaxLength(22)]
    public string Isbn { get; set; }
}
#endregion