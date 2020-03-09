using nutracker.Models.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nutracker.Entities.FoodEntities
{
    public class FoodEntity
    {
        public long id { get; set; }

        public Boolean validated { get; set; }

        public string name { get; set; }

        public FoodCategory foodCategory { get; set; }

        public FoodInfo foodInfo { get; set; }

        public string barcode { get; set; }

        public double portion { get; set; }
    }
}
