namespace WithEndpoints.Endpoints.Customers;

public class DeleteCustomerByIdEndpoint : EndpointBaseSync
	.WithRequest<GetCustomerByIdRequest>
	.WithResult<Customer>
{
	private readonly CustomersService _customersService;

	public DeleteCustomerByIdEndpoint(CustomersService customersService, ILogger<DeleteCustomerByIdEndpoint> logger)
	{
		_customersService = customersService;
	}

	[EndpointGroupName("Customers")]
	[HttpDelete("/Api/Customers/{id}")]
	public override Customer Handle([FromRoute] GetCustomerByIdRequest request)
	{
		return _customersService.DeleteCustomer(request.id);
	}
}