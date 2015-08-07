using CoderCamps;
using LessonsUnlimited_V2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LessonsUnlimited_V2._0.Services
{
    public class LessonServices : LessonsUnlimited_V2._0.Services.ILessonServices
    {
        private IGenericRepository _repo;
        public LessonServices(IGenericRepository repo)
        {
            _repo = repo;
        }

        public IList<Lesson> List()
        {
            // Retrieve the 'Lesson' entity from the database, and return it as a List
            return _repo.Query<Lesson>().ToList();
        }
       

        public Lesson Find(int id)
        {
            return _repo.Find<Lesson>(id);
        }

        

    }
}