using System;
namespace CarDealerShip.Services
{
    public interface ITeslaServices
    {
        void Create(CarDealerShip.Models.Tesla tesla);
        void Delete(int id);
        void Edit(CarDealerShip.Models.Tesla tesla);
        CarDealerShip.Models.Tesla Find(int id);
        System.Collections.Generic.IList<CarDealerShip.Models.Tesla> List();
    }
}
