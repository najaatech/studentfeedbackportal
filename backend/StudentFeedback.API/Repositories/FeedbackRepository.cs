using Microsoft.EntityFrameworkCore;
using StudentFeedback.API.Models;

namespace StudentFeedback.API.Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext _context;

        public FeedbackRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Feedback?> GetFeedbackAsync(int studentId, int courseId)
        {
            return await _context.Feedback
                .FirstOrDefaultAsync(f => f.StudentId == studentId && f.CourseId == courseId);
        }

        public async Task AddFeedbackAsync(Feedback feedback)
        {
            await _context.Feedback.AddAsync(feedback);
        }

        public async Task<bool> IsStudentEnrolledAsync(int studentId, int courseId)
        {
            return await _context.Enrollments
                .AnyAsync(e => e.StudentId == studentId && e.CourseId == courseId);
        }

        public async Task<List<Feedback>> GetAllFeedbackAsync()
        {
            return await _context.Feedback
                .Include(f => f.Course)
                .ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
