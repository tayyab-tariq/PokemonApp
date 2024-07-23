using AutoMapper;
using TayyabTest.Data;
using TayyabTest.Interfaces;
using TayyabTest.Models;
namespace TayyabTest.Repository
{
    public class CountryRepository : ICountryRepository
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CountryRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool CountryExists(int id)
        {
            return _context.Countries.Any(c => c.Id == id);
        }

        public ICollection<Country> GetCountries()
        {
            return _context.Countries.ToList();
        }

        Country ICountryRepository.GetCountry(int id)
        {
            return _context.Countries.Where(e => e.Id == id).FirstOrDefault();
        }

        Country ICountryRepository.GetCountryByOwner(int ownerId)
        {

            return _context.Owners.Where(o => o.Id == ownerId).Select(c => c.Country).FirstOrDefault();
        }

        ICollection<Owner> ICountryRepository.GetOwnersFromACountry(int countryId)
        {
            throw new NotImplementedException();
        }
    }
}
