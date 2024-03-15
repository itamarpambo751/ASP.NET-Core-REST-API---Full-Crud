using Microsoft.AspNetCore.Mvc;
using REST_API___APS.NET_Core.Dtos;
using REST_API___APS.NET_Core.Errors;
using REST_API___APS.NET_Core.Models;
using REST_API___APS.NET_Core.Services;

namespace REST_API___APS.NET_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CreateCustomerService _createCustomerService;
        private readonly ReadAllCustomerService _readAllCustomersService;
        public CustomerController() { 
            this._createCustomerService = new CreateCustomerService();
            this._readAllCustomersService = new ReadAllCustomerService();
        }
        [HttpPost]
        public IActionResult Create([FromBody] Customer customer)
        {
            if (customer == null) { return BadRequest("Invalid data!"); }

            try
            {
                return Ok(_createCustomerService.Execute(customer));

            } catch (Exception ex)
            {
                return BadRequest(new JsonResult(ex.Message));
            }
        }
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var service = this._readAllCustomersService.Execute();
            
            return Ok(service);
        }
    }
}