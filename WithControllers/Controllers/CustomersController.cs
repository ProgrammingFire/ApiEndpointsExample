using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using Shared.Services;

namespace WithControllers.Controllers;

[ApiController]
[Route("Api/[controller]")]
public class CustomersController
{
	private readonly CustomersService _customersService;

	public CustomersController(CustomersService customerService)
	{
		_customersService = customerService;
	}

	[HttpGet]
	public IEnumerable<Customer> GetAll()
	{
		return _customersService.GetCustomers();
	}

	[HttpGet("{id}")]
	public Customer GetOne(int id)
	{
		return _customersService.GetCustomer(id);
	}

	[HttpPost]
	public Customer Create([FromBody] Customer customer)
	{
		return _customersService.AddCustomer(customer);
	}

	[HttpPut("{id}")]
	public Customer Update(int id, [FromBody] Customer customer)
	{
		return _customersService.UpdateCustomer(id, customer);
	}

	[HttpDelete("{id}")]
	public Customer Delete(int id)
	{
		return _customersService.DeleteCustomer(id);
	}
}