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
    public class AuthorController : ControllerBase
    {
        private IDataService _dataServices;
        private IMapper _mapper;
        public AuthorController(IDataService dataService, IMapper mapper)
        {
            this._dataServices = dataService;
            this._mapper = mapper;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> HelloWorld(int id)
        {
            var data = new Author { AuthorName = "This is my author" };
            var bookData = _dataServices.GetAuthor(id);
            return Ok(bookData);
        }

        [HttpGet]
        [Route("all")]
        public IEnumerable<Author> AllAuthors()
        {
            return _dataServices.GetAllAuthors();
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddAuthor(AuthorModel authorModel)
        {

            var author = _mapper.Map<Author>(authorModel);
            _dataServices.AddAuthor(author);
            return Ok();
        }
    }
}
