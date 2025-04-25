using Microsoft.AspNetCore.Mvc;
using E_Learning_API.Data;
using E_Learning_API.Models;

namespace E_Learning_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LessonController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LessonController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Lesson
        [HttpGet]
        public IActionResult GetAllLessons()
        {
            var lessons = _context.Lessons.ToList();
            return Ok(lessons);
        }

        // GET: api/Lesson/{id}
        [HttpGet("{id}")]
        public IActionResult GetLesson(int id)
        {
            var lesson = _context.Lessons.Find(id);
            if (lesson == null) return NotFound();
            return Ok(lesson);
        }

        // POST: api/Lesson
        [HttpPost]
        public IActionResult CreateLesson([FromBody] Lesson lesson)
        {
            _context.Lessons.Add(lesson);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetLesson), new { id = lesson.Id }, lesson);
        }

        // PUT: api/Lesson/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateLesson(int id, [FromBody] Lesson updatedLesson)
        {
            var lesson = _context.Lessons.Find(id);
            if (lesson == null) return NotFound();

            lesson.Title = updatedLesson.Title;
            lesson.Description = updatedLesson.Description;
            lesson.Content = updatedLesson.Content;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/Lesson/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteLesson(int id)
        {
            var lesson = _context.Lessons.Find(id);
            if (lesson == null) return NotFound();

            _context.Lessons.Remove(lesson);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
