using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {

        // GET
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeId);

        // POST 
        bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);

        // PUT
        bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon);

        // DELETE
        bool DeletePokemon(Pokemon pokemon);

        //
        bool PokemonExists(int pokeId);
        bool Save();

    }
}
