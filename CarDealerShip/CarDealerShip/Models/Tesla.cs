using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealerShip.Models
{
    public class Tesla: Car
    {
        public double Range { get; set; }
        public double ChargeTime { get; set; }
    }
}