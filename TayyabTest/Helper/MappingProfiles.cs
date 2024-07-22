using AutoMapper;
using TayyabTest.Dto;
using TayyabTest.Models;

namespace TayyabTest.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
