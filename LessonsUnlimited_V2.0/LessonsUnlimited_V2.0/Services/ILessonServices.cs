using System;
namespace LessonsUnlimited_V2._0.Services
{
    public interface ILessonServices
    {
        void Create(LessonsUnlimited_V2._0.Models.Lesson lesson);
        void Delete(int id);
        void Edit(LessonsUnlimited_V2._0.Models.Lesson lesson);
        LessonsUnlimited_V2._0.Models.Lesson Find(int id);
        System.Collections.Generic.IList<LessonsUnlimited_V2._0.Models.Lesson> List();
    }
}
