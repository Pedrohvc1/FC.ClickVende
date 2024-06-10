using FC.ClickVende.Business.DTOs;
using FC.ClickVende.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace FC.ClickVende.API.Controllers;

[ApiController]
[Route("api/[controller]")]
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
    public IActionResult Get(Guid id)
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

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        _clientService.DeleteClient(id);
        return Ok();
    }

    [HttpPut]
    public IActionResult Put([FromBody] ClientDTO client)
    {
        if (client is null)
            return BadRequest();
        
        _clientService.UpdateClient(client);
        return Ok();
    }

}
