using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using NetTopologySuite.Geometries;

namespace EFQuerying.Tags;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new SpatialContext())
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        using (var context = new SpatialContext())
        {
            //var nearestPeople = (from f in context.People.TagWith("This is my spatial query!")
            //                     orderby f.Location.Distance(myLocation) descending
            //                     select f).Take(5).ToList();
            #region BasicQueryTag

            var myLocation = new Point(1, 2);
            var nearestPeople = context.QueryAsync(linq => linq.People.Select()
                .OrderBy(v => @v.Location.Distance(myLocation)).ToList(), tag: "This is my spatial query!");
            #endregion
        }

        using (var context = new SpatialContext())
        {
            #region ChainedQueryTags
            var results = Limit(GetNearestPeople(context, new Point(1, 2)), 25).ToList();
            #endregion
        }

        using (var context = new SpatialContext())
        {
            #region MultilineQueryTag
            var results = Limit(GetNearestPeople(context, new Point(1, 2)), 25).TagWith(
                @"This is a multi-line
string").ToList();
            #endregion
        }
    }

    //TODO:支持这种视图逻辑
    #region QueryableMethods
    private static List<Person> GetNearestPeople(SpatialContext context, Point myLocation)
        => context.Query(linq => linq.People.Select()
                .OrderBy(v => @v.Location.Distance(myLocation)).ToList(), tag: "This is my spatial query!");

    private static IQueryable<T> Limit<T>(IQueryable<T> source, int limit) => source.TagWith("Limit").Take(limit);
    #endregion
}

public class Person
{
    public int Id { get; set; }
    public Point Location { get; set; }
}