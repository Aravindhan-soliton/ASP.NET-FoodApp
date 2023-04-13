using FoodApp.Model;

namespace FoodApp.DataProvider
{
    public class InMemoryDataProvide
    {
        List<Hotels> _hotels;
        Dictionary<string, List<MenuList>> _hotelMenu;
        User user1;

        public InMemoryDataProvide()
        {
            SetHotels();
            SetMenus();
            user1 = new
        }
        public void SetHotels()
        {
            _hotels = new List<Hotels>();
            _hotels.Add(new Hotels() { hotelName = "ARAYA BHAVAN", phoneNumber = "0987654321", hotelId = "1" });
            _hotels.Add(new Hotels() { hotelName = "RIYA BHAVAN", phoneNumber = "1234567890", hotelId = "2" });
        }
        public void SetMenus()
        {
            _hotelMenu = new Dictionary<string, List<MenuList>>();
            _hotelMenu.Add("1", new List<MenuList>() { new MenuList() { productName = "Dosa", productPrice = "100" }, new MenuList() { productName = "IDLY", productPrice = "40" }, new MenuList() { productName = "Poori", productPrice = "20" } });
            _hotelMenu.Add("2", new List<MenuList>() { new MenuList() { productName = "Dosa", productPrice = "110" }, new MenuList() { productName = "VADA", productPrice = "40" }, new MenuList() { productName = "IDLY", productPrice = "20" } });
        }
        public IEnumerable<Hotels> GetHotels()
        {
            return _hotels;
        }
        public IEnumerable<MenuList> GetMenu(string hotel)
        {
            return _hotelMenu[hotel];
        }
        public void AddToCart(User user)
        {
        }
    }
}