using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Infrastructure.Database;

public class LibraryDbContext : DbContext
{
    public DbSet<Author> Authors => Set<Author>();
    public DbSet<Book> Books => Set<Book>();
    public DbSet<BookType> BookTypes => Set<BookType>();
    public DbSet<BookStatus> BookStatus => Set<BookStatus>();
    public DbSet<CallCard> CallCards => Set<CallCard>();
    public DbSet<LibraryCard> LibraryCards => Set<LibraryCard>();
    public DbSet<LibraryConfiguration> LibraryConfigurations => Set<LibraryConfiguration>();
    public DbSet<Publisher> Publishers => Set<Publisher>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(
            "Data Source=.;Initial Catalog=LibraryManagementSystem;Integrated Security=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LibraryDbContext).Assembly);
    }
}