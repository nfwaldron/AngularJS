using CarDealerShip.Models;
using CarDealerShip.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarDealerShip.Controllers
{
    public class TeslaController : ApiController
    {
        private ITeslaServices _service;
        public TeslaController(ITeslaServices service)
        {
            _service = service;
        }

        // GET: api/Tesla
        public IEnumerable<Tesla> Get()
        {
            return _service.List();
        }

        // GET: api/Tesla/5
        public Tesla Get(int id)
        {
            return _service.Find(id);
        }

        // POST: api/Tesla
        public HttpResponseMessage Post(Tesla tesla)
        {
            if (ModelState.IsValid)
            {
                if (tesla.Id == 0)
                {
                    _service.Create(tesla);
                    return Request.CreateResponse(HttpStatusCode.Created, tesla);
                }
                else
                {
                    _service.Edit(tesla);
                    return Request.CreateResponse(HttpStatusCode.OK, tesla);
                }

            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
        }

        // PUT: api/Tesla/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tesla/5
        public void Delete(int id)
        {
        }
    }
}
