using LibraryManagementSystem.Domain.Entities;

namespace LibraryManagementSystem.App.Configurations.Seeder.PredefinedData;

public static class PredefinedBookTypes
{
    public static IEnumerable<BookType> GetPredefinedBookTypes(string contentRootPath)
    {
        var csvFileBookTypes = Path.Combine(contentRootPath, "Setup", "BookTypes.csv");
        if (!File.Exists(csvFileBookTypes)) return null;

        using var reader = new StreamReader(csvFileBookTypes);
        var bookTypes = new List<BookType>();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line?.Split(',');
            var bookType = CreateBookType(values[0], values[1]);
            bookTypes.Add(bookType);
        }

        return bookTypes;
    }

    private static BookType CreateBookType(string id, string name)
    {
        return new BookType(new Guid(id), name);
    }
}