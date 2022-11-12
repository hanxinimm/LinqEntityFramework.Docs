using Hunter.EntityFramework;
using System;

namespace EFModeling.EntityTypes.DataAnnotations.FunctionNameAndSchemaContainsParameters;

internal partial class MyContext : LinqDbContext
{
    [DbFunction(nameof(GetHostBlogsWithMultiplePosts))]
    protected DbView<GetHostBlogWithMultiplePosts> GetHostBlogsWithMultiplePosts(int postType) => default;
}

public class GetHostBlogWithMultiplePosts
{
    public int BlogId { get; set; }
    public string Url { get; set; }
}