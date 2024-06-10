using FC.ClickVende.Business.DTOs;
using FC.ClickVende.Data.Models;
using FC.ClickVende.Data.Repositories;

namespace FC.ClickVende.Business.Services;

public class ClientService
{
    private readonly ClientRepository _clientRepository;
    public ClientService()
    {
        _clientRepository = new ClientRepository();
    }

    #region Public Methods
    public void CreateClient(ClientDTO clientDto)
    {
        var client = new Client
        {
            Name = clientDto.Name,
            Cpf = clientDto.Cpf,
            Email = clientDto.Email,
            PhoneNumber = clientDto.PhoneNumber,
            Adress = clientDto.Adress
        };
        _clientRepository.Add(client);
    }

    public ClientDTO GetClientById(Guid id)
    {
        var client = _clientRepository.GetById(id);
        if (client is null)
            return null;

        var clientDto = new ClientDTO
        {
            Name = client.Name,
            Cpf = client.Cpf,
            Email = client.Email,
            PhoneNumber = client.PhoneNumber,
            Adress = client.Adress
        };
        return clientDto;

    }

    public List<ClientDTO> GetClients()
    {
        var clients = _clientRepository.GetClients();
        if (clients is null)
            return null;

        return ListToModel(clients);
    }

    public void DeleteClient(Guid id)
    {
        _clientRepository.Delete(id);
    }

    public void UpdateClient(ClientDTO client)
    {
        var clientToUpdate = new Client
        {
            Name = client.Name,
            Cpf = client.Cpf,
            Email = client.Email,
            PhoneNumber = client.PhoneNumber,
            Adress = client.Adress
        };
        _clientRepository.Update(clientToUpdate);
    }

    #endregion


    #region Private Methods
    private List<ClientDTO> ListToModel(List<Client> clients)
    {
        var listDto = new List<ClientDTO>();
        foreach (var client in clients)
        {
            var clientDto = new ClientDTO
            {
                Name = client.Name,
                Cpf = client.Cpf,
                Email = client.Email,
                PhoneNumber = client.PhoneNumber,
                Adress = client.Adress
            };
            listDto.Add(clientDto);
        }
        return listDto;
    }
    #endregion

}
