using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nutracker.Models.Food
{
    public class FoodInfo
    {
        public double foodCalories { get; set; }

        // TODO: davon Zucker
        public double carbohydrates { get; set; }

        // TODO: gesättigte und ungesättigte
        public double fat { get; set; }

        public double protein { get; set; }

        public double salt { get; set; }
    }
}
