using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IOwnerRepository
    {
        // GET
        ICollection<Owner> GetOwners(); 
        Owner GetOwner(int ownerId);
        ICollection<Owner> GetOwnerOfAPokemon(int pokeId);
        ICollection<Pokemon> GetPokemonByOwner(int ownerId);    

        // POST 
        bool CreateOwner(Owner owner);

        // PUT
        bool UpdateOwner(Owner owner);

        // DELETE
        bool DeleteOwner(Owner owner);

        //
        bool OwnerExists(int ownerId);
        bool Save();

    }
}
