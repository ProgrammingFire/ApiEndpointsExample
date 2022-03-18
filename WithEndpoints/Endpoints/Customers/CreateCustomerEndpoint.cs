namespace WithEndpoints.Endpoints.Customers;

public class CreateCustomerEndpoint : EndpointBaseSync
	.WithRequest<CreateCustomerRequest>
	.WithResult<Customer>
{
	private readonly CustomersService _customersService;

	public CreateCustomerEndpoint(CustomersService customersService)
	{
		_customersService = customersService;
	}

	[EndpointGroupName("Customers")]
	[HttpPost("/Api/Customers")]
	public override Customer Handle(CreateCustomerRequest request)
	{
		return _customersService.AddCustomer(new Customer()
		{
			Id = request.id,
			Name = request.name,
			Email = request.email
		});
	}
}