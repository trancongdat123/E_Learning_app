using E_Learning_API.Models;
using System.Collections.Generic;

namespace E_Learning_API.Services
{
    public class LessonService : ILessonService
    {
        private readonly List<Lesson> _lessons = new();

        public List<Lesson> GetAllLessons()
        {
            return _lessons;
        }

        public void CreateLesson(Lesson lesson)
        {
            _lessons.Add(lesson);
        }
    }
}
