namespace WithEndpoints.Endpoints.Customers;

public class UpdateCustomerEndpoint : EndpointBaseSync
	.WithRequest<UpdateCustomerRequest>
	.WithResult<Customer>
{
	private readonly CustomersService _customersService;

	public UpdateCustomerEndpoint(CustomersService customersService, ILogger<UpdateCustomerEndpoint> logger)
	{
		_customersService = customersService;
	}

	[EndpointGroupName("Customers")]
	[HttpPut("/Api/Customers")]
	public override Customer Handle(UpdateCustomerRequest request)
	{
		return _customersService.UpdateCustomer(request.id, new Customer()
		{
			Name = request.name,
			Email = request.email
		});
	}
}