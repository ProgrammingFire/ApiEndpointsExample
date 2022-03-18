using Shared.Models;

namespace Shared.Services;

public class CustomersService
{
	private Customer[] _customers = new[]{
		new Customer {
			Id = 1,
			Name = "John Doe",
			Email = "john@doe.com"
		}
	};

	public Customer[] GetCustomers()
	{
		return _customers;
	}

	public Customer GetCustomer(int id)
	{
		return _customers.First(c => c.Id == id);
	}

	public Customer AddCustomer(Customer customer)
	{
		_customers = _customers.Append(customer).ToArray();
		return customer;
	}

	public Customer UpdateCustomer(int id, Customer customer)
	{
		var existingCustomer = _customers.First(c => c.Id == id);
		existingCustomer.Name = customer.Name;
		existingCustomer.Email = customer.Email;
		return existingCustomer;
	}

	public Customer DeleteCustomer(int id)
	{
		var customer = _customers.First(c => c.Id == id);
		_customers = _customers.Where(c => c.Id != id).ToArray();
		return customer;
	}
}