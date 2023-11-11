using AutoMapper;
using CrudWebApiAspCore.Controllers;
using CrudWebApiAspCore.Models;

namespace CrudWebApiAspCore
{
    public class FilmeProfile : Profile
    {
        
        public FilmeProfile()
        {
            CreateMap<FilmeDto,Filme>().ReverseMap();
        }
    }
}