using Microsoft.AspNetCore.Mvc;
using EFDataAccess.Models;
using EFDataServices;
using System.Collections.Generic;
using AutoMapper;
using CoreAPIOld.Models;
using CoreAPIOld.Services.Implementation;
using CoreAPIOld.Services.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace CoreAPIOld.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private IDataService _dataServices;
        private IMapper _mapper;
        private IBookService _bookService;

        public BookController(IDataService dataService, IMapper mapper, IBookService bookService)
        {
            this._dataServices = dataService;
            this._mapper = mapper;
            this._bookService = bookService;
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var book = _dataServices.GetBook(id);
            return Ok(book);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddBook(BookModel bookModel)
        {
            if (_bookService.CompareNames(bookModel.Title, _dataServices))
            {
                return Ok(new { status = "Book already exists"});
            }
            
            var book = _mapper.Map<Book>(bookModel);
            _dataServices.AddBook(book);

            return Ok();
        }
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = _dataServices.GetAllBooks();
            return Ok(books);
        }
    }
}
