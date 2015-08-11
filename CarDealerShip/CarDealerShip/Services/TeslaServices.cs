using CarDealerShip.Models;
using CoderCamps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealerShip.Services
{
    public class TeslaServices : CarDealerShip.Services.ITeslaServices
    {
        private IGenericRepository _repo;
        public TeslaServices( IGenericRepository repo)
        {
            _repo = repo;
        }

        public IList<Tesla> List()
        {
            return _repo.Query<Tesla>().ToList();
        }

        public Tesla Find(int id)
        {
            return _repo.Find<Tesla>(id);
        }

        public void Create (Tesla tesla)
        {
            _repo.Add<Tesla>(tesla);
            _repo.SaveChanges();
        }

        public void Edit (Tesla tesla)
        {
            var original = this.Find(tesla.Id);
            original.Picture = tesla.Picture;
            original.Price = tesla.Price;
            original.Range = tesla.Range;
            original.ChargeTime = tesla.ChargeTime;
            original.BriefDescription = tesla.BriefDescription;
            original.FullDescription = tesla.FullDescription;
            original.Title = tesla.Title;
            _repo.SaveChanges();
        }

        public void Delete(int id)
        {
            _repo.Delete<Tesla>(id);
            _repo.SaveChanges();
        }


    }
}