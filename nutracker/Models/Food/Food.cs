using System;

namespace nutracker.Models.Food
{
    public class Food
    {
        public long Id { get; set; }

        public Boolean Validated { get; set; }

        public string Name { get; set; }

        public FoodCategory FoodCategory { get; set; }

        public FoodInfo FoodInfo { get; set; }

        public string Barcode { get; set; }

        public double Portion { get; set; }
    }
}
