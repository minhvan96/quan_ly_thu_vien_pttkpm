using LibraryManagementSystem.App.Configurations.Seeder.PredefinedData;
using LibraryManagementSystem.Infrastructure.Database;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Polly;
using Polly.Retry;

namespace LibraryManagementSystem.App.Configurations.Seeder;

public class LibraryContextSeed
{
    public static AsyncRetryPolicy CreatePolicy(string prefix, int retries = 3)
    {
        return Policy.Handle<SqlException>().WaitAndRetryAsync(
            retries,
            retry => TimeSpan.FromSeconds(5),
            (exception, timeSpan, retry, ctx) => { }
        );
    }

    public static async Task SeedAsync(LibraryDbContext context)
    {
        var policy = CreatePolicy(nameof(LibraryDbContext));
        await policy.ExecuteAsync(async () =>
        {
            var executingFolder = Path.GetDirectoryName(Application.ExecutablePath);

            if (!await context.Publishers.AnyAsync())
            {
                var predefinedPublishers = PredefinedPublishers.GetPredefinedPublishers(executingFolder);
                context.AddRange(predefinedPublishers);
            }

            if (!await context.Authors.AnyAsync())
            {
                var authors = PredefinedAuthors.GetPredefinedAuthors(executingFolder);
                context.AddRange(authors);
            }

            if (!await context.BookTypes.AnyAsync())
            {
                var bookTypes = PredefinedBookTypes.GetPredefinedBookTypes(executingFolder);
                context.AddRange(bookTypes);
            }

            if (!await context.Books.AnyAsync())
            {
                var books = PredefinedBooks.GetPredefinedBooks(executingFolder);
                context.AddRange(books);
            }

            //if (!await context.LibraryCards.AnyAsync())
            //{
            //    var library = PredefinedLibraryCards.GetPredefinedBooks(executingFolder);
            //    context.AddRange(library);
            //}

            if (!await context.LibraryConfigurations.AnyAsync())
            {
                var configurations = PredefinedLibraryConfiguration.GetPredefinedLibraryConfigurations(executingFolder);
                context.AddRange(configurations);
            }

            await context.SaveChangesAsync();
        });
    }
}