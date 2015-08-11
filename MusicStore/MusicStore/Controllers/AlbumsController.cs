using MusicStore.Models;
using MusicStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MusicStore.Controllers
{
    public class AlbumsController : ApiController
    {
        public IAlbumServices _service;

        public AlbumsController(IAlbumServices service)
        {
            _service = service;
        }


        // GET: api/Albums
        public IEnumerable<Album> Get()
        {
            return _service.List();
        }

        // GET: api/Albums/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Albums
        public HttpResponseMessage Post (Album album)
        {
            return null;
        }

        // PUT: api/Albums/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Albums/5
        public void Delete(int id)
        {
        }
    }
}
