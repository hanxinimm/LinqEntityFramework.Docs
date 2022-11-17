//using System.Runtime.CompilerServices;
//using System.Threading.Tasks;
//using System.Threading;
//using Hunter.EntityFramework;
//using System;
//using System.Collections.Generic;

//namespace Intro
//{
//    partial class BloggingContext : ILinqDbContextQuery<BloggingContext.IDbContextQueryLambdaExpression>, ILinqDbContextExecute<BloggingContext.IDbContextExecuteLambdaExpression>
//    {
//        public TResult Query<TResult>(Func<IDbContextQueryLambdaExpression, IDbQueryResulExpression<TResult>> linqExpression, ICallerLineNumberPlaceholder? placeholder = default, [CallerLineNumber] int callerLineNumber = 0)
//        {
//            return Query(linqExpression, callerLineNumber);
//        }

//        public List<TResult> Query<TResult>(Func<IDbContextQueryLambdaExpression, IDbQueryListExpression<TResult>> linqExpression, ICallerLineNumberPlaceholder? placeholder = default, [CallerLineNumber] int callerLineNumber = 0)
//        {
//            return Query<List<TResult>>(linqExpression.Method, linqExpression.Target, callerLineNumber);
//        }

//        public IEnumerable<TResult> Query<TResult>(Func<IDbContextQueryLambdaExpression, IDbQueryEnumerableExpression<TResult>> linqExpression, ICallerLineNumberPlaceholder? placeholder = default, [CallerLineNumber] int callerLineNumber = 0)
//        {
//            return Query<IEnumerable<TResult>>(linqExpression.Method, linqExpression.Target, callerLineNumber);
//        }

//        public TResult[] Query<TResult>(Func<IDbContextQueryLambdaExpression, IDbQueryArrayExpression<TResult>> linqExpression, ICallerLineNumberPlaceholder? placeholder = default, [CallerLineNumber] int callerLineNumber = 0)
//        {
//            return Query<TResult[]>(linqExpression.Method, linqExpression.Target, callerLineNumber);
//        }

//        public ValueTask<TResult> QueryAsync<TResult>(Func<IDbContextQueryLambdaExpression, IDbQueryResulExpression<TResult>> linqExpression, CancellationToken cancellationToken = default, ICallerLineNumberPlaceholder? placeholder = default, [CallerLineNumber] int callerLineNumber = 0)
//        {
//            return QueryAsync(linqExpression, cancellationToken, callerLineNumber);
//        }

//        public ValueTask<List<TResult>> QueryAsync<TResult>(Func<IDbContextQueryLambdaExpression, IDbQueryListExpression<TResult>> linqExpression, CancellationToken cancellationToken = default, ICallerLineNumberPlaceholder? placeholder = default, [CallerLineNumber] int callerLineNumber = 0)
//        {
//            return QueryAsync<List<TResult>>(linqExpression.Method, linqExpression.Target, cancellationToken, callerLineNumber);
//        }

//        public ValueTask<IEnumerable<TResult>> QueryAsync<TResult>(Func<IDbContextQueryLambdaExpression, IDbQueryEnumerableExpression<TResult>> linqExpression, CancellationToken cancellationToken = default, ICallerLineNumberPlaceholder? placeholder = default, [CallerLineNumber] int callerLineNumber = 0)
//        {
//            return QueryAsync<IEnumerable<TResult>>(linqExpression.Method, linqExpression.Target, cancellationToken, callerLineNumber);
//        }

//        public ValueTask<TResult[]> QueryAsync<TResult>(Func<IDbContextQueryLambdaExpression, IDbQueryArrayExpression<TResult>> linqExpression, CancellationToken cancellationToken = default, ICallerLineNumberPlaceholder? placeholder = default, [CallerLineNumber] int callerLineNumber = 0)
//        {
//            return QueryAsync<TResult[]>(linqExpression.Method, linqExpression.Target, cancellationToken, callerLineNumber);
//        }

//        public void Execute(Func<IDbContextExecuteLambdaExpression, int> linqExpression, ICallerLineNumberPlaceholder? placeholder = default, [CallerLineNumber] int callerLineNumber = 0)
//        {
//            base.Execute(linqExpression, callerLineNumber);
//        }

//        public interface IDbContextQueryLambdaExpression : IDbEngineLambdaExpression
//        {
//            public IDbEntityRelationalQueryLambdaExpression<global::Intro.Blog> Blogs { get; set; }

//            public IDbEntityRelationalQueryLambdaExpression<global::Intro.Blog> CompatiblePosts { get; set; }

//            public IDbEntityRelationalQueryLambdaExpression<global::Intro.Post> ClassPosts { get; set; }

//            public IDbEntityRelationalQueryLambdaExpression<global::Intro.Post> InterfacePosts { get; set; }

//            public IDbEntityRelationalQueryLambdaExpression<global::Intro.GetHostPost> GetPosts(int postType) => default;
//        }

//        public interface IDbContextExecuteLambdaExpression : IDbEngineLambdaExpression
//        {
//            public IDbEntityRelationalExecuteLambdaExpression<global::Intro.Blog> Blogs { get; set; }

//            public IDbEntityRelationalExecuteLambdaExpression<global::Intro.Blog> CompatiblePosts { get; set; }

//            public IDbEntityRelationalExecuteLambdaExpression<global::Intro.Post> ClassPosts { get; set; }

//            public IDbEntityRelationalExecuteLambdaExpression<global::Intro.Post> InterfacePosts { get; set; }
//        }
//    }
//}