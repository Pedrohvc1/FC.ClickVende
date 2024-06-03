using FC.ClickVende.Business.DTOs;
using FC.ClickVende.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace FC.ClickVende.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
    private readonly ClientService _clientService;
    public ClientController()
    {
        _clientService = new ClientService();
    }
    [HttpPost]
    public IActionResult Post([FromBody] ClientDTO client)
    {
        _clientService.CreateClient(client);
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var clientDTO = _clientService.GetClientById(id);
        if (clientDTO is null)
            return NotFound();

        return Ok(clientDTO);
    }

    [HttpGet("GetClientList")]
    public IActionResult GetClientList()
    {
        var clients = _clientService.GetClients();
        if (clients is null)
            return NotFound();
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromRoute] ClientDTO client)
    {
        _clientService.UpdateClient(id, client);
        return Ok();
    }

}
