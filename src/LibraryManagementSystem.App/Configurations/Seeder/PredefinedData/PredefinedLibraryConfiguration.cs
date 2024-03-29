﻿using LibraryManagementSystem.Domain.Entities;

namespace LibraryManagementSystem.App.Configurations.Seeder.PredefinedData;

public static class PredefinedLibraryConfiguration
{
    public static IEnumerable<LibraryConfiguration> GetPredefinedLibraryConfigurations(string contentRootPath)
    {
        var csvFileLibraryConfiguration = Path.Combine(contentRootPath, "Setup", "LibraryConfiguration.csv");
        if (!File.Exists(csvFileLibraryConfiguration)) return null;

        using var reader = new StreamReader(csvFileLibraryConfiguration);
        var configurations = new List<LibraryConfiguration>();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            string?[]? values = line?.Split(',');
            var configuration = CreateBook(values[0], values[1], values[2], values[3]);
            configurations.Add(configuration);
        }

        return configurations;
    }

    private static LibraryConfiguration CreateBook(string? id, string? code, string? name, string? value)
    {
        return new LibraryConfiguration(new Guid(id),
            code,
            name,
            Convert.ToInt32(value));
    }
}