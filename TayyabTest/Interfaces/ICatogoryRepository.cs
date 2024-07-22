using TayyabTest.Models;

namespace TayyabTest.Interfaces
{
    public interface ICatogoryRepository
    {
        ICollection<Category> GetCategories();

        Category GetCategory(int id);

        ICollection<Pokemon> GetPokemonsByCategory(int categoryId);

        bool CategoryExists(int id);
    }
}
