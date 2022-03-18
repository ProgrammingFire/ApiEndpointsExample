namespace WithEndpoints.Endpoints.Customers;

public class GetCustomerByIdEndpoint : EndpointBaseSync
	.WithRequest<GetCustomerByIdRequest>
	.WithResult<Customer>
{
	private readonly CustomersService _customersService;

	public GetCustomerByIdEndpoint(CustomersService customersService)
	{
		_customersService = customersService;
	}

	[EndpointGroupName("Customers")]
	[HttpGet("/Api/Customers/{id}")]
	public override Customer Handle([FromRoute] GetCustomerByIdRequest request)
	{
		return _customersService.GetCustomer(request.id);
	}
}