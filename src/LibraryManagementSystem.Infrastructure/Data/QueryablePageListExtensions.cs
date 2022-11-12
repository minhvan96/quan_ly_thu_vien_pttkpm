using LibraryManagementSystem.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Infrastructure.Data;

public static class QueryablePageListExtensions
{
    /// <summary>
    ///     Converts the specified source to <see cref="IPagedList{T}" /> by the specified <paramref name="pageSize" /> and
    ///     <paramref name="pageSize" />.
    /// </summary>
    /// <typeparam name="T">The type of the source.</typeparam>
    /// <param name="source"></param>
    /// <param name="pageIndex">The source to paging.</param>
    /// <param name="pageSize">The index of the page.</param>
    /// <param name="cancellationToken">
    ///     The size of the page.
    ///     A &lt;see cref=&quot;CancellationToken&quot; /&gt; to observe while waiting for the task to complete.
    /// </param>
    /// <param name="indexFrom">The start index value.</param>
    /// <returns>An instance of the inherited from <see cref="IPagedList{T}" /> interface.</returns>
    public static async Task<IPagedList<T>> ToPagedListAsync<T>(this IQueryable<T> source,
        int pageIndex,
        int pageSize,
        int indexFrom = 1,
        CancellationToken cancellationToken = default)
    {
        ValidateIndexFrom(indexFrom, pageIndex);
        var count = await source.CountAsync(cancellationToken)
            .ConfigureAwait(false);
        var items = await source.Skip((pageIndex - indexFrom) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken)
            .ConfigureAwait(false);

        var pagedList = new PagedList<T>
        {
            PageIndex = pageIndex,
            PageSize = pageSize,
            IndexFrom = indexFrom,
            TotalItems = count,
            Items = items,
            TotalPages = (int)Math.Ceiling(count / (double)pageSize)
        };

        return pagedList;
    }

    private static void ValidateIndexFrom(int indexFrom, int pageIndex)
    {
        if (indexFrom > pageIndex)
            throw new ArgumentException(
                $"indexFrom: {indexFrom} > pageIndex: {pageIndex}, must indexFrom <= pageIndex");
    }
}