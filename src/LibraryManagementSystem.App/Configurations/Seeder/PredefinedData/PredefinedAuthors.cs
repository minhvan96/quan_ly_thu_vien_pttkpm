using LibraryManagementSystem.Domain.Entities;

namespace LibraryManagementSystem.App.Configurations.Seeder.PredefinedData;

public static class PredefinedAuthors
{
    public static IEnumerable<Author> GetPredefinedAuthors(string contentRootPath)
    {
        var csvFileAuthors = Path.Combine(contentRootPath, "Setup", "Authors.csv");
        if (!File.Exists(csvFileAuthors)) return null;

        using var reader = new StreamReader(csvFileAuthors);
        var authors = new List<Author>();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line?.Split(',');
            var author = CreateNewAuthor(values[0], values[1]);
            authors.Add(author);
        }

        return authors;
    }

    private static Author CreateNewAuthor(string id, string name)
    {
        return new Author(new Guid(id), name);
    }
}