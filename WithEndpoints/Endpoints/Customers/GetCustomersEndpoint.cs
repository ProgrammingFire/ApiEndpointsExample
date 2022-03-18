namespace WithEndpoints.Endpoints.Customers;

public class GetCustomersEndpoint : EndpointBaseSync
	.WithoutRequest
	.WithActionResult<Customer[]>
{
	private readonly CustomersService _customersService;

	public GetCustomersEndpoint(CustomersService customersService)
	{
		_customersService = customersService;
	}

	[EndpointGroupName("Customers")]
	[HttpGet("/Api/Customers")]
	public override ActionResult<Customer[]> Handle()
	{
		return Ok(_customersService.GetCustomers());
	}
}