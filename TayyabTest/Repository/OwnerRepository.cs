
using TayyabTest.Data;
using TayyabTest.Interfaces;
using TayyabTest.Models;

namespace TayyabTest.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly DataContext _context;

        public OwnerRepository(DataContext context)
        {
            _context = context;
        }

        public Owner GetOwner(int ownerId)
        {
            return _context.Owners.Where(o => o.Id == ownerId).FirstOrDefault();
        }

        ICollection<Owner> IOwnerRepository.GetOwnerOfAPokemon(int pokeId)
        {
            return _context.PokemonOwners.Where(p => p.PokemonId == pokeId).Select(o => o.Owner).ToList();
        }

        ICollection<Owner> IOwnerRepository.GetOwners()
        {
            return _context.Owners.ToList();
        }

        ICollection<Pokemon> IOwnerRepository.GetPokemonByOwner(int ownerId)
        {
            return _context.PokemonOwners.Where(p => p.Owner.Id == ownerId).Select(p => p.Pokemon).ToList();
        }

        bool IOwnerRepository.OwnerExists(int ownerId)
        {
            return _context.Owners.Any(o => o.Id == ownerId);
        }

        bool IOwnerRepository.CreateOwner(Owner owner)
        {
            throw new NotImplementedException();
        }

        bool IOwnerRepository.DeleteOwner(Owner owner)
        {
            throw new NotImplementedException();
        }

        bool IOwnerRepository.Save()
        {
            throw new NotImplementedException();
        }

        bool IOwnerRepository.UpdateOwner(Owner owner)
        {
            throw new NotImplementedException();
        }
    }

}