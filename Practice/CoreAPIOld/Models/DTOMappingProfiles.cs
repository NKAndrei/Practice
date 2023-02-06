using AutoMapper;
using EFDataAccess.Models;

namespace CoreAPIOld.Models
{
    public class DTOMappingProfiles : Profile
    {
        public DTOMappingProfiles()
        {
            CreateMap<Author, AuthorModel>();
            CreateMap<AuthorModel, Author>();
            CreateMap<BookModel, Book>();
        }
    }
}
