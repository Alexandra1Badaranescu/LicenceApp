using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LicenceApp1.Models.Entities;
using LicenceApp1.Models.DTOs;
using LicenceApp1.Repositories.CustomerRepository;
using LicenceApp1.Repositories.ProductRepository;
using Microsoft.AspNetCore.Mvc;

namespace LicenceApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repositoryCustomer;

        public CustomerController(ICustomerRepository repositoryCustomer)
        {
            _repositoryCustomer = repositoryCustomer;

        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customers = await _repositoryCustomer.GetAllCustomers();
            return Ok(customers);
        }
        [HttpGet("{name}")]

        public async Task<IActionResult> GetCustomerByName(string name)
        {
            var customer = await _repositoryCustomer.GetCustomerByName(name);
            if (customer == null)
            {
                return BadRequest("The Licence you search cannot be found!");
            }
            var CustomerToReturn = new CustomerDTO(customer);

            return Ok(CustomerToReturn);

        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetCustomerById(int id)
        {
            var customer = await _repositoryCustomer.GetCustomerById(id);
            if (customer == null)
            {
                return BadRequest("The Licence you search cannot be found!");
            }
            var CustomerToReturn = new CustomerDTO(customer);

            return Ok(CustomerToReturn);

        }

    }


}
