using E_Learning_API.Models;
using System.Collections.Generic;

namespace E_Learning_API.Services
{
    public interface ILessonService
    {
        List<Lesson> GetAllLessons();
        void CreateLesson(Lesson lesson);
    }
}
