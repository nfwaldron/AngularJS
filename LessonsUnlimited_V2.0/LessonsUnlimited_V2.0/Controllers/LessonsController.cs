using LessonsUnlimited_V2._0.Models;
using LessonsUnlimited_V2._0.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LessonsUnlimited_V2._0.Controllers
{
    public class LessonsController : ApiController
    {
        private ILessonServices _service;
        public LessonsController(ILessonServices service)
        {
            _service = service;
        }
        
        // GET: api/Lessons
        // IEnumerable is an interface, and its use here
        // means that the entity returned from this function must be iteratable.
        // Since we will return a List, which can be iterated over, we should be good.
        public IEnumerable<Lesson> GetLessons()
        {
            return _service.List();
        }

        // GET: api/Lessons/5
        public Lesson Get(int id)
        {
            return _service.Find(id);
        }

        // POST: api/Lessons
        public HttpResponseMessage Post(Lesson lesson)
        {
            if (ModelState.IsValid)
            {
                if (lesson.Id==0)
                {
                    _service.Create(lesson);
                    return Request.CreateResponse(HttpStatusCode.Created, lesson);
                }

                else
                {
                    _service.Edit(lesson);
                    return Request.CreateResponse(HttpStatusCode.OK, lesson);
                }

            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, this.ModelState);
        }

        // PUT: api/Lessons/5
        public void Put(int id, [FromBody]string value)
        {
            
        }

        // DELETE: api/Lessons/5
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
