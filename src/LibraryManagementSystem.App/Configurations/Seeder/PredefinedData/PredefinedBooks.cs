﻿using LibraryManagementSystem.Domain.Entities;

namespace LibraryManagementSystem.App.Configurations.Seeder.PredefinedData;

public static class PredefinedBooks
{
    public static IEnumerable<Book> GetPredefinedBooks(string contentRootPath)
    {
        var csvFileBooks = Path.Combine(contentRootPath, "Setup", "Books.csv");
        if (!File.Exists(csvFileBooks)) return null;

        using var reader = new StreamReader(csvFileBooks);
        var books = new List<Book>();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line?.Split(',');
            var book = CreateBook(values[0], values[1], values[2], values[3], values[4], values[5], int.Parse(values[6]), int.Parse(values[7]));
            books.Add(book);
        }

        return books;
    }

    private static Book CreateBook(string id, string name, string typeId, string authorId,
        string publisherId, string publishedDate, int inStock, int publishYear)
    {
        return new Book(new Guid(id),
            name,
            new Guid(typeId),
            new Guid(authorId),
            new Guid(publisherId),
            inStock,
            publishYear,
            Convert.ToDateTime(publishedDate));
    }
}