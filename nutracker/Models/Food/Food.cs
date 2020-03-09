using System;

namespace nutracker.Models.Food
{
    public class Food
    {
        public Boolean validated { get; set; }

        public string name { get; set; }

        public FoodCategory foodCategory { get; set; }

        public FoodInfo foodInfo { get; set; }

        public string barcode { get; set; }

        public double portion { get; set; }
    }
}
