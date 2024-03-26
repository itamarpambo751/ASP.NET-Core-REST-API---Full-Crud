using Microsoft.AspNetCore.Mvc;
using REST_API___APS.NET_Core.Models;
using REST_API___APS.NET_Core.Services;

namespace REST_API___APS.NET_Core.Controllers
{
    [Route("api/v1/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult Create([FromBody] Customer customer)
        {
            if (customer == null) { return BadRequest("Invalid data!"); }

            try
            {
                return Ok(new CreateCustomerService().Execute(customer));

            } catch (Exception ex)
            {
                return BadRequest(new JsonResult(ex.Message));
            }
        }
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult Get()
        {
            var service = new ReadAllCustomerService().Execute();

            if (service.Count is 0) return NotFound("User was not found!");

            return Ok(service);
        }
        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Get([FromRoute] int id)
        {
            try
            {
                var service = new ReadOneCustomerService().Execute(id);

                return Ok(new JsonResult(service));

            } catch (Exception ex)
            {
                return BadRequest(new JsonResult(ex.Message));
            }
        }
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Put([FromBody] Customer customer)
        {
            try
            {
                var service = new UpdateCustomerService().Execute(customer);

                return Ok(service);
            } catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        [Route("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult Delete([FromRoute] int id) {
            try
            {
                List<Customer> customers = new DeleteCustomerService().Execute(id);

                return Ok(customers);

            } catch (Exception ex)
            {
                return NotFound(new JsonResult(ex.Message));
            }
        }
    }
}