using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        // GET
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewsByReviewer(int reviewerId);

        // POST 
        bool CreateReviewer(Reviewer reviewer);

        // PUT
        bool UpdateReviewer(Reviewer reviewer);

        // DELETE
        bool DeleteReviewer(Reviewer reviewer);

        //
        bool ReviewerExists(int reviewerId);
        bool Save();


    }
}
