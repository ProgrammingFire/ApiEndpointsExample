namespace WithEndpoints.Requests.Customers;

public class UpdateCustomerRequest
{
	public int id { get; set; }
	public string? name { get; set; }
	public string? email { get; set; }
}