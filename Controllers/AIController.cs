using Microsoft.AspNetCore.Mvc;
using E_Learning_API.Data;
using E_Learning_API.Models;

namespace E_Learning_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AIController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AIController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("chat")]
        public IActionResult Chat([FromBody] ChatMessage message)
        {
            if (string.IsNullOrEmpty(message.Message))
                return BadRequest("Message is required.");

            // Giả sử AI trả lời đơn giản
            var reply = $"AI trả lời: Bạn vừa nói '{message.Message}'";

            var chatRecord = new ChatMessage
            {
                Message = message.Message,
                Reply = reply,
                CreatedAt = DateTime.UtcNow
            };

            _context.ChatMessages.Add(chatRecord);
            _context.SaveChanges();

            return Ok(chatRecord);
        }

        [HttpGet("history")]
        public IActionResult GetChatHistory()
        {
            var messages = _context.ChatMessages
                                   .OrderByDescending(m => m.CreatedAt)
                                   .ToList();
            return Ok(messages);
        }
    }
}
