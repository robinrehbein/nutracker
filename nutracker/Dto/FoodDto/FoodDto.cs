using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nutracker.Dto.FoodDto
{
    public class FoodDto
    {
        public Boolean validated { get; set; }

        public string name { get; set; }

        public FoodCategoryDto foodCategoryDto { get; set; }

        public FoodInfoDto foodInfoDto { get; set; }

        public string barcode { get; set; }

        public double portion { get; set; }
    }
}
