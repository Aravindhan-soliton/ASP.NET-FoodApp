namespace FoodApp.Model
{
    public class User
    {
        public string userName { get; set; }
        public string phoneNumber { get; set; }
        public Dictionary<string, List<MenuList>> cart { get; set; }
    }
}
