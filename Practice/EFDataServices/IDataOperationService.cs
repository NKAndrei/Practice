using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDataAccess.Models;
using EFDataAccess.Context;

namespace EFDataServices
{
    public interface IDataOperationService
    {
        public void AddAuthor(Author author);
        public Author GetAuthor(int authorId);
        public IEnumerable<Author> GetAllAuthors();
        public void AddBook(Book book);
        public Book GetBook(int bookId);
        public IEnumerable<Book> GetAllBooks();
        bool BookTitleExists(string name);
    }
}
