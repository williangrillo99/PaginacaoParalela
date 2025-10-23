using Domain;
using MediatR;

namespace Application.ListarPersonagem;

public sealed class ListarPersonagemQuery : IRequest<List<Personagem>>
{
    public string? Nome { get; init; }
    
    public string? Status { get; init; }
}