namespace nutracker.Models.Food
{
    public class FoodCategory
    {
        public long Id { get; set; }
        enum Drink
        {
            nonalcoholic, alcoholic
        }

        enum Food
        {
            vegetable, animal, fungal
        }
    }
}
