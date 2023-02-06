using EFDataAccess.Models;
using EFDataServices;
using System.Collections.Generic;
using AutoMapper;
using CoreAPIOld.Models;
using CoreAPIOld.Services.Interfaces;

namespace CoreAPIOld.Services.Implementation
{
    public class BookService : IBookService
    {
        public bool CompareNames(string name, IDataService _dataServices)
        {
            var dataService = _dataServices;
            return dataService.BookTitleExists(name);
        }
    }
}
