namespace WithEndpoints.Requests.Customers;

public class CreateCustomerRequest
{
	public int id { get; set; }
	public string? name { get; set; }
	public string? email { get; set; }
}