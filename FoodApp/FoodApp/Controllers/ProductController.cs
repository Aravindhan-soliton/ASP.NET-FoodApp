//using Microsoft.AspNetCore.Components;
using FoodApp.DataProvider;
using FoodApp.Model;
using Microsoft.AspNetCore.Mvc;
//using FoodApp.Model.Hotels;
namespace FoodApp.Controllers
{
    [Route("Hotels")]
    public class ProductController : ControllerBase
    {
        InMemoryDataProvide _hotelNames;
        public ProductController()
        {
            _hotelNames = new InMemoryDataProvide();
        }
        [HttpGet]
        public JsonResult GetHotels()
        {
            return new JsonResult(_hotelNames.GetHotels());
        }
        [HttpGet("{hotelID}")]
        public JsonResult GetHotelsMenuItems(string hotelID)
        {
            return new JsonResult(_hotelNames.GetMenu(hotelID));
        }
        //[HttpGet("{}")]
        [HttpPost("{userCart}")]
        public ActionResult PostProductMenus([FromBody] User user)
        {
            return new JsonResult("");
        }
        [HttpPost]
        public async Task<ActionResult<User>> CreateEmployee(User user)
        {
            try
            {
                if (user == null)
                    return BadRequest();

                var createdEmployee = await .AddEmployee(user);

                return CreatedAtAction(nameof(GetEmployee),
                    new { id = createdEmployee.EmployeeId }, createdEmployee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }
    }
}