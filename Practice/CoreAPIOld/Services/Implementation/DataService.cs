using CoreAPIOld.Services.Interfaces;
using EFDataAccess.Models;
using System.Collections.Generic;
using EFDataServices;


namespace CoreAPIOld.Services.Implementation
{
    public class DataService : IDataService
    {
        private IDataOperationService _dataOperationService;

        public DataService()
        {
            _dataOperationService = new DataOperations();
        }

        public void AddAuthor(Author author)
        {
            _dataOperationService.AddAuthor(author);
        }

        public void AddBook(Book book)
        {
            _dataOperationService.AddBook(book);
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return _dataOperationService.GetAllAuthors();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _dataOperationService.GetAllBooks();
        }

        public Author GetAuthor(int authorId)
        {
            return _dataOperationService.GetAuthor(authorId);
        }

        public Book GetBook(int bookId)
        {
            return _dataOperationService.GetBook(bookId);
        }
        public bool BookTitleExists(string name)
        {
            return _dataOperationService.BookTitleExists(name);
        }
    }
}
