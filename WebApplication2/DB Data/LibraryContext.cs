using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.DB_Data

{
    using Microsoft.EntityFrameworkCore;

    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }

    }
}
