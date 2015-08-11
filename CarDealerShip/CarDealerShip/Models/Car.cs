using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealerShip.Models
{
    public abstract class Car
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public string BriefDescription { get; set; }
        public string FullDescription { get; set; }
        public string Picture { get; set; }

    }
}