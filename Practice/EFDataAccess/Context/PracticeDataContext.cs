using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDataAccess.Models;

namespace EFDataAccess.Context
{
    public class PracticeDataContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\ProjectModels; Initial Catalog = PracticeDatabase; Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var authorList = new Author[]
            {
                new Author { AuthorId = 1, AuthorName = "Pablo Eskobar" },
                new Author { AuthorId = 2, AuthorName = "Scooby Doo" },
                new Author { AuthorId = 3, AuthorName = "Rick Sanchez" }
            };
            var bookList = new Book[]
            {
                new Book { BookId = 1, Title = "Cooking Meth" },
                new Book { BookId = 2, Title = "Breaking Bad" },
                new Book { BookId = 3, Title = "DIY" }
            };

            modelBuilder.Entity<Author>().HasData(authorList);
            modelBuilder.Entity<Book>().HasData(bookList);
        }
    }
}
