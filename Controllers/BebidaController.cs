using Microsoft.AspNetCore.Mvc;
using RestauranteAPI.Repositories;

namespace RestauranteAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BebidaController : ControllerBase
{
    private static List<Bebida> bebidas = new List<Bebida>();

    private readonly IBebidaRepository _repository;

    public BebidaController(IBebidaRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<List<Bebida>>> GetBebidas()
    {
        var bebidas = await _repository.GetAllAsync();

        return Ok(bebidas);
    }
}