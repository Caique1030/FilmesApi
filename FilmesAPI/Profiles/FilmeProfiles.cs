using AutoMapper;
using FilmesAPI.Controllers.Models;
using FilmesApi.Data.Dtos;

namespace FilmesApi.Profiles;

public class FilmeProfiles : Profile
{
    public FilmeProfiles()
    {
        CreateMap<CreateFilmeDto, Filme>();
    }
}
