using System;
namespace CarDealerShip.Services
{
    public interface IRollsRoyceServices
    {
        void Create(CarDealerShip.Models.RollsRoyce rolls);
        void Delete(int id);
        void Edit(CarDealerShip.Models.RollsRoyce rolls);
        CarDealerShip.Models.RollsRoyce Find(int id);
        System.Collections.Generic.IList<CarDealerShip.Models.RollsRoyce> List();
    }
}
