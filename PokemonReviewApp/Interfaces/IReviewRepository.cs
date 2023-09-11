using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        // GET
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);   
        ICollection<Review> GetReviewsOfAPokemon(int pokeId);   

        // POST 
        bool CreateReview(Review review);

        // PUT
        bool UpdateReview(Review review);

        // DELETE
        bool DeleteReview(Review review);
        bool DeleteReviews(List<Review> reviews);

        //
        bool ReviewExists(int reviewId);
        bool Save();

    }
}
