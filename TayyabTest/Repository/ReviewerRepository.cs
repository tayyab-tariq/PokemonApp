using AutoMapper;
using TayyabTest.Data;
using TayyabTest.Interfaces;
using TayyabTest.Models;

namespace TayyabTest.Repository
{
    public class ReviewerRepository : IReviewerRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ReviewerRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        bool IReviewerRepository.CreateReviewer(Reviewer reviewer)
        {
            throw new NotImplementedException();
        }

        bool IReviewerRepository.DeleteReviewer(Reviewer reviewer)
        {
            throw new NotImplementedException();
        }

        public Reviewer GetReviewer(int reviewerId)
        {
            throw new NotImplementedException();
            // return _context.Reviewers.Where(r => r.Id == reviewerId).Include(e => e.Reviews).FirstOrDefault();
        }

        public ICollection<Reviewer> GetReviewers()
        {
            return _context.Reviewers.ToList();
        }

        public ICollection<Review> GetReviewsByReviewer(int reviewerId)
        {
            return _context.Reviews.Where(r => r.Reviewer.Id == reviewerId).ToList();
        }

        public bool ReviewerExists(int reviewerId)
        {
            return _context.Reviewers.Any(r => r.Id == reviewerId);
        }

        bool IReviewerRepository.Save()
        {
            throw new NotImplementedException();
        }

        bool IReviewerRepository.UpdateReviewer(Reviewer reviewer)
        {
            throw new NotImplementedException();
        }
    }
}