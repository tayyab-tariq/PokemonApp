using AutoMapper;
using TayyabTest.Data;
using TayyabTest.Interfaces;
using TayyabTest.Models;

namespace TayyabTest.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ReviewRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        bool IReviewRepository.CreateReview(Review review)
        {
            throw new NotImplementedException();
        }

        bool IReviewRepository.DeleteReview(Review review)
        {
            throw new NotImplementedException();
        }

        bool IReviewRepository.DeleteReviews(List<Review> reviews)
        {
            throw new NotImplementedException();
        }

        public Review GetReview(int reviewId)
        {
            return _context.Reviews.Where(r => r.Id == reviewId).FirstOrDefault();
        }

        public ICollection<Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }

        public ICollection<Review> GetReviewsOfAPokemon(int pokeId)
        {
            return _context.Reviews.Where(r => r.Pokemon.Id == pokeId).ToList();
        }

        public bool ReviewExists(int reviewId)
        {
            return _context.Reviews.Any(r => r.Id == reviewId);
        }

        bool IReviewRepository.Save()
        {
            throw new NotImplementedException();
        }

        bool IReviewRepository.UpdateReview(Review review)
        {
            throw new NotImplementedException();
        }
    }

}
