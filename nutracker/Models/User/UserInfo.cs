namespace nutracker.Models.User
{
    public class UserInfo
    {
        public enum Gender
        {
            male, female, diverse
        }

        public WeightInfo WeightInfo { get; set; }

        public double Height { get; set; }

        public double CalorieGoal { get; set; }

        public double CalorieToday { get; set; }
    }
}
