using LibraryManagementSystem.Domain.Entities;

namespace LibraryManagementSystem.App.Configurations.Seeder.PredefinedData;

public static class PredefinedBooks
{
    public static IEnumerable<Book> GetPredefinedBooks(string contentRootPath)
    {
        var csvFileBooks = Path.Combine(contentRootPath, "Setup", "Books.csv");
        if (!File.Exists(csvFileBooks)) return null;

        using var reader = new StreamReader(csvFileBooks);
        var bookTypes = new List<Book>();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line?.Split(',');
            var bookType = CreateBook(values[0], values[1], values[2], values[3], values[4]);
            bookTypes.Add(bookType);
        }

        return bookTypes;
    }

    private static Book CreateBook(string id, string name, string barCode, string typeId, string authorId)
    {
        return new Book(new Guid(id), name, barCode, new Guid(typeId), new Guid(authorId), Guid.Empty, 0);
    }
}