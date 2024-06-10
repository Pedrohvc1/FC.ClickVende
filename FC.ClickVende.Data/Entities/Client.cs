namespace FC.ClickVende.Data.Models;

public class Client
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public string Adress { get; set; } = string.Empty;

}