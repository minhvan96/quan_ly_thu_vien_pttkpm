using System.Linq.Expressions;
using LinqKit;

namespace LibraryManagementSystem.Infrastructure.Data;

public static class QueryExtensions
{
    /// <summary>
    ///     Append OR condition to Initial Search Predicates
    /// </summary>
    /// <param name="searchPredicate">Initial Search Predicate</param>
    /// <param name="predicates">Additional Search Predicate</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static Expression<Func<T, bool>> BuildSearchPredicate<T>(this Expression<Func<T, bool>>? searchPredicate,
        params Expression<Func<T, bool>>[] predicates)
        where T : class
    {
        searchPredicate ??= PredicateBuilder.New<T>(true);
        var searchPredicates = new Queue<Expression<Func<T, bool>>>();
        foreach (var predicate in predicates) searchPredicates.Enqueue(predicate);

        if (!searchPredicates.Any())
            return searchPredicate;
        //searchPredicate = searchPredicates.Dequeue();
        while (searchPredicates.Any())
            searchPredicate = searchPredicate.Or(searchPredicates.Dequeue());
        return searchPredicate;
    }
}