﻿namespace nutracker.Models.Food
{
    public class FoodInfo
    {
        public long Id { get; set; }

        public double FoodCalories { get; set; }

        // TODO: davon Zucker
        public double Carbohydrates { get; set; }

        // TODO: gesättigte und ungesättigte
        public double Fat { get; set; }

        public double Protein { get; set; }

        public double Salt { get; set; }
    }
}
