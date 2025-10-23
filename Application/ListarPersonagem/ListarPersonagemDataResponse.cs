using Domain;

namespace Application.ListarPersonagem;

public sealed class ListarPersonagemDataResponse
{
    public required List<ListarPersonagemResponse>? Data { get; init; }
}

public sealed class ListarPersonagemResponse
{
    public required string Nome { get; set; }
    public required string Ativo { get; set; }
}