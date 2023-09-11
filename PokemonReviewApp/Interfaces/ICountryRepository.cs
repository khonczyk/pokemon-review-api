using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        // GET
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromACountry(int countryId);

        // POST
        bool CreateCountry(Country country);

        // PUT
        bool UpdateCountry(Country country);

        // DELETE
        bool DeleteCountry(Country country);

        //
        bool CountryExists(int id);
        bool Save();


    }
}
