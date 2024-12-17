using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace admındeneme.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomerController()
        {
            _customerService = new CustomerService(); // Service örneği oluşturuluyor
        }

        // GET: api/customer
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAllCustomers()
        {
            try
            {
                var customers = await _customerService.GetAllCustomersAsync();
                if (customers == null || customers.Count == 0)
                    return NotFound("No customers found.");

                return Ok(customers);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("test")]
        public async Task<ActionResult> TestConnection()
        {
            try
            {
                var customers = await _customerService.GetAllCustomersAsync();
                return Ok(new { Message = "Connection Successful", CustomerCount = customers.Count });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
