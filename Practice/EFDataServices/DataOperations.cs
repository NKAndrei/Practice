using EFDataAccess.Models;
using EFDataAccess.Context;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EFDataServices
{
    public class DataOperations : IDataOperationService
    {
        PracticeDataContext _context;

        public DataOperations()
        {
            _context = new PracticeDataContext();
        }

        public Author GetAuthor(int authorId)
        {
            return _context.Authors.Find(authorId);
        }
        public IEnumerable<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }
        public void AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
        public Book GetBook(int bookId)
        {
            return _context.Books.Find(bookId);
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }
        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public bool BookTitleExists(string name)
        {
            var book = _context.Books.FirstOrDefault(x => x.Title == name);
            if (book == null)
            {
                return false;
            }
            return true;
        }
    }
}
