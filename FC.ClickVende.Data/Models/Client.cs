namespace FC.ClickVende.Data.Models;

public class Client
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;

}