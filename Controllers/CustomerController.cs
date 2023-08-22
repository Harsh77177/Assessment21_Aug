using CustomerService1;
using CustomerService1.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace CustomerService1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService _inter;
        public CustomerController(ICustomerService inter)
        {
            _inter = inter;
        }
        [HttpGet]
        public IActionResult Get()
        {
            if (_inter.GetAllCustomers == null)
                return NotFound();
            else return Ok(_inter.GetAllCustomers());
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            Customer temp = _inter.AddCustomer(customer);



            return Created("201", temp);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_inter.DeleteCustomer(id));
        }
    }
}
