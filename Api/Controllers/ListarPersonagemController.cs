using Application;
using Application.ListarPersonagem;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
public sealed class ListarPersonagemController(IMediator mediator) : ControllerBase
{
    [HttpGet("listar")]
    public async Task<ActionResult<List<Personagem>>> ListarAsync(
        ListarPersonagemRequest request, 
        CancellationToken cancellationToken)
    {
        var queryMediator = new ListarPersonagemQuery
        {
            Nome = request.Nome,
            Status = request.Status,
        };
        var personagens = await mediator.Send(
            queryMediator, cancellationToken);
        
        return Ok(personagens);
    }
}