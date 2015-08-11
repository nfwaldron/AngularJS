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
    public class RollsRoyceController : ApiController
    {
        private IRollsRoyceServices _service;

        public RollsRoyceController(IRollsRoyceServices service)
        {
            _service = service;
        }

        // GET: api/RollsRoyce
        public IEnumerable<RollsRoyce> Get()
        {
            return _service.List();
        }

        // GET: api/RollsRoyce/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RollsRoyce
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/RollsRoyce/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RollsRoyce/5
        public void Delete(int id)
        {
        }
    }
}
