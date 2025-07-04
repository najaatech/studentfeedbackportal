using StudentFeedback.API.DTOs;
using StudentFeedback.API.Models;

namespace StudentFeedback.API.Services
{
    public interface IFeedbackService
    {
        Task SubmitFeedbackAsync(SubmitFeedbackDto dto, int studentId);
    }
}