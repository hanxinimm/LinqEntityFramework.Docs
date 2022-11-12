using Hunter.EntityFramework;
using System;

namespace EFModeling.EntityTypes.DataAnnotations.FunctionNameAndSchema;

internal partial class MyContext : LinqDbContext
{
    [DbFunction(nameof(BlogsWithMultiplePosts))]
    protected DbView<BlogWithMultiplePosts> BlogsWithMultiplePosts() => default;
}

public class BlogWithMultiplePosts
{
    public int BlogId { get; set; }
    public string Url { get; set; }
}