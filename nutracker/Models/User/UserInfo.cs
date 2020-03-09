namespace nutracker.Models.User
{
    public class UserInfo
    {
        public enum Gender
        {
            male, female, diverse
        }

        public WeightInfo weightInfo { get; set; }

        public double height { get; set; }

        public double calorieGoal { get; set; }

        public double calorieToday { get; set; }
    }
}
