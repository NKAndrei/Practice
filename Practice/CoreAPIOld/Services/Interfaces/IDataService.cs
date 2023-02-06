using EFDataAccess.Models;
using System.Collections.Generic;

namespace CoreAPIOld.Services.Interfaces
{
    public interface IDataService
    {
        Author GetAuthor(int authorId);

        Book GetBook(int bookId);

        IEnumerable<Author> GetAllAuthors();

        IEnumerable<Book> GetAllBooks();

        void AddAuthor(Author author);

        void AddBook(Book book);

        bool BookTitleExists(string name);
    }
}
