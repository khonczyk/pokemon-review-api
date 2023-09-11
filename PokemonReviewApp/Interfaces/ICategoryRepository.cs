using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        // GET
        ICollection<Category> GetCategories();
        Category GetCategory(int categoryId);
        ICollection<Pokemon> GetPokemonByCategory(int categoryId);

        // POST
        bool CreateCategory(Category category);

        // PUT
        bool UpdateCategory(Category category);

        // DELETE
        bool DeleteCategory(Category category);


        //
        bool CategoryExists(int categoryId);
        bool Save();


    }
}
