using Hunter.EntityFramework;
using System;

namespace EFModeling.EntityTypes.DataAnnotations.FunctionNameAndSchema;

internal partial class MyContext : LinqDbContext
{
    protected DbFunction<Blog> BlogsWithMultiplePosts { get; set; }
}

[DbFunction("BlogsWithMultiplePosts")]
public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
}