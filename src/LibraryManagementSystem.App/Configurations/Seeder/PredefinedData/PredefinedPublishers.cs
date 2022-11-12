using LibraryManagementSystem.Domain.Entities;

namespace LibraryManagementSystem.App.Configurations.Seeder.PredefinedData;

public static class PredefinedPublishers
{
    public static IEnumerable<Publisher> GetPredefinedPublishers(string contentRootPath)
    {
        var csvFilePublishers = Path.Combine(contentRootPath, "Setup", "Publishers.csv");
        if (!File.Exists(csvFilePublishers)) return null;

        using var reader = new StreamReader(csvFilePublishers);
        var publishers = new List<Publisher>();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line?.Split(',');
            var publisher = CreatePublisher(values[0], values[1]);
            publishers.Add(publisher);
        }

        return publishers;
    }

    private static Publisher CreatePublisher(string id, string name)
    {
        return new Publisher(new Guid(id), name);
    }
}