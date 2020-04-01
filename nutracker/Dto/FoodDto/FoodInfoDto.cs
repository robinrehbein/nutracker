using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nutracker.Dto.FoodDto
{
    public class FoodInfoDto
    {
        public double FoodCalories { get; set; }

        // TODO: davon Zucker
        public double Carbohydrates { get; set; }

        // TODO: gesättigte und ungesättigte
        public double Fat { get; set; }

        public double Protein { get; set; }

        public double Salt { get; set; }
    }
}
