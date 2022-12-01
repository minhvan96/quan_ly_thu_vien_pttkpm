using LibraryManagementSystem.Domain.Entities;

namespace LibraryManagementSystem.App.Configurations.Seeder.PredefinedData;

public static class PredefinedLibraryCards
{
    public static IEnumerable<LibraryCard> GetPredefinedBooks(string contentRootPath)
    {
        var csvFileBooks = Path.Combine(contentRootPath, "Setup", "LibraryCard.csv");
        if (!File.Exists(csvFileBooks)) return null;

        using var reader = new StreamReader(csvFileBooks);
        var books = new List<LibraryCard>();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line?.Split(',');
            var book = CreateBook(values[0], values[1], DateTime.Parse(values[2]), values[3], values[4], values[5], DateTime.Parse(values[6]));
            books.Add(book);
        }

        return books;
    }

    private static LibraryCard CreateBook(string id, string name, DateTime birthDay, string address, string email, string typeOfReader,
        DateTime creationDate)
    {
        return new LibraryCard(new Guid(id),
            name,
            birthDay,
            address,
            email,
            typeOfReader,
            creationDate);
    }
}