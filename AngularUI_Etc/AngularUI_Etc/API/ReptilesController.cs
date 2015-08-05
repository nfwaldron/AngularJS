using AngularUI_Etc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularUI_Etc.API
{
    public class ReptilesController : ApiController
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        public IEnumerable<Reptile> GetReptiles(string filter)
    {
        return _db.Reptiles
            .Where(r=>r.Name.StartsWith(filter))
            .OrderBy(r=>r.Name)
            .ToList();

    }

    }
}
