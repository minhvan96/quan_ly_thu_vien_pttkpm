﻿using LibraryManagementSystem.App.Configurations.Seeder.PredefinedData;
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

            if (!await context.Authors.AnyAsync())
            {
                var authors = PredefinedAuthors.GetPredefinedAuthors(executingFolder);
                context.AddRange(authors);
                await context.SaveChangesAsync();
            }

            if (!await context.BookTypes.AnyAsync())
            {
                var bookTypes = PredefinedBookTypes.GetPredefinedBookTypes(executingFolder);
                context.AddRange(bookTypes);
                await context.SaveChangesAsync();
            }

            if (!await context.Books.AnyAsync())
            {
                var books = PredefinedBooks.GetPredefinedBooks(executingFolder);
                context.AddRange(books);
                await context.SaveChangesAsync();
            }

            await context.SaveChangesAsync();
        });
    }
}