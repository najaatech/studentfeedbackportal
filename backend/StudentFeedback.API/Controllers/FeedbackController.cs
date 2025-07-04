using Microsoft.AspNetCore.Mvc;
using StudentFeedback.API.DTOs;
using StudentFeedback.API.Services;

namespace StudentFeedback.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        // POST: api/feedback
        [HttpPost]
        public async Task<IActionResult> SubmitFeedback([FromBody] SubmitFeedbackDto dto)
        {
            // Simulate student ID via headers or middleware
            if (!HttpContext.Request.Headers.TryGetValue("x-student-id", out var studentIdHeader) ||
                !int.TryParse(studentIdHeader, out var studentId))
            {
                return BadRequest("Missing or invalid student ID header.");
            }

            // return Ok(dto);

            try
            {
                await _feedbackService.SubmitFeedbackAsync(dto, studentId);
                return Ok(new { message = "Feedback submitted successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        // TODO: implement api/report

    }
}
