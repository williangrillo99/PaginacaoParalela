using Application;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
public sealed class ListarPersonagemController(IListagemPaginacaoAppService listagemPaginacaoAppService) 
    : ControllerBase
{
    [HttpGet("paralela")]
    public async Task<ActionResult<List<Personagem>>> PaginacaoParalelaAsync(
        CancellationToken cancellationToken)
    {
        
        var listagem = await listagemPaginacaoAppService.PaginacaoParalelaAsync(cancellationToken);
        return Ok(listagem);
    }
    
    [HttpGet("async")]
    public async Task<ActionResult<List<Personagem>>> PaginacaoAsync(
        CancellationToken cancellationToken)
    {
        var listagem = await listagemPaginacaoAppService.PaginacaoAsync(cancellationToken);
        return Ok(listagem);
    }
}