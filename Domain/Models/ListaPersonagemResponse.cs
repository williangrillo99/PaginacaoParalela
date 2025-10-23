using System.Text.Json.Serialization;

namespace Domain.Models;

public sealed record ListaPersonagemResponseWm
{
    [JsonPropertyName("info")]
    public required PaginacaoResponseWm Paginacao { get; init; }
    
    [JsonPropertyName("results")]
    public required List<PersonagemReponseWm> Personagens { get; init; }
}

public class PersonagemReponseWm
{
    [JsonPropertyName("name")]
    public required string Nome { get; init; }
}
public class PaginacaoResponseWm
{
    [JsonPropertyName("pages")]
    public required int TotalPaginas { get; init; }
    
    [JsonPropertyName("next")]
    public string? ProximaPagina { get; init; }
}