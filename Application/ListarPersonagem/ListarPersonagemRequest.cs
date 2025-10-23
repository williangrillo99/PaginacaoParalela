using Microsoft.AspNetCore.Mvc;

namespace Application.ListarPersonagem;

public sealed record ListarPersonagemRequest
{
    [FromQuery(Name = "nome")]
    public string? Nome { get; init; }
    
    [FromQuery(Name = "status")]
    public string? Status { get; init; }

}