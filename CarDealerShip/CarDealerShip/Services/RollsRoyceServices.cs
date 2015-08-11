using CarDealerShip.Models;
using CoderCamps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealerShip.Services
{
    public class RollsRoyceServices : CarDealerShip.Services.IRollsRoyceServices
    {

        private IGenericRepository _repo;
        public RollsRoyceServices(IGenericRepository repo)
        {
            _repo = repo;
        }

        public IList<RollsRoyce> List()
        {
            return _repo.Query<RollsRoyce>().ToList();
        }

        public RollsRoyce Find(int id)
        {
            return _repo.Find<RollsRoyce>(id);
        }

        public void Create (RollsRoyce rolls)
        {
            _repo.Add<RollsRoyce>(rolls);
            _repo.SaveChanges();
        }

        public void Edit (RollsRoyce rolls)
        {
            var original = this.Find(rolls.Id);
            original.Picture = rolls.Picture;
            original.Price = rolls.Price;
            original.GasMileage = rolls.GasMileage;
            original.BriefDescription = rolls.BriefDescription;
            original.FullDescription = rolls.FullDescription;
            original.Title = rolls.Title;
            _repo.SaveChanges();
        }

        public void Delete(int id)
        {
            _repo.Delete<RollsRoyce>(id);
            _repo.SaveChanges();
        }
    }
}