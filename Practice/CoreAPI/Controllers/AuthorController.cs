using Microsoft.AspNetCore.Mvc;
using EFDataAccess.Models;
using EFDataServices;

namespace CoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private AuthorDataOperations _services;
        public AuthorController()
        {
            _services = new AuthorDataOperations();
        }

        [HttpGet]
        public string HelloWorld()
        {
            return "Hello world";
        }

        [HttpGet]
        [Route("[controller]/all")]
        public IEnumerable<Author> AllAuthors()
        {
            return _services.GetAll();
        }
    }
}
