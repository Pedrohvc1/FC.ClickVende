using FC.ClickVende.Data.Models;

namespace FC.ClickVende.Data.Repositories;

public class ClientRepository
{
    private List<Client> _clients = new();

    public void Add(Client client)
    {
        _clients.Add(client);
    }
    public Client GetById(Guid id)
    {
        var client =  _clients.FirstOrDefault(x => x.Id == id);
        return client;
    }
    public List<Client> GetClients()
    {
        return _clients.ToList();
    }
    public void Delete(Guid id)
    {
        var client = GetById(id);
        if (client is null)
            return;
        _clients.Remove(client);
    }
    public void Update(Client client)
    {
        var clientToUpdate = GetById(client.Id);
        if (clientToUpdate is null)
            return;
        clientToUpdate.Name = client.Name;
        clientToUpdate.Cpf = client.Cpf;
        clientToUpdate.Email = client.Email;
        clientToUpdate.PhoneNumber = client.PhoneNumber;
        clientToUpdate.Adress = client.Adress;
    }
}
