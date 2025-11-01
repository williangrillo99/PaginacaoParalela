using System.Text.Json.Serialization;

namespace Domain.Models;

public sealed record ListaPersonagemResponseWm
{
    [JsonPropertyName("info")]
    public required PaginacaoWmResponse Paginacao { get; init; }
    
    [JsonPropertyName("results")]
    public required List<PersonagemWmReponse> Personagens { get; init; }
}

public class PersonagemWmReponse
{
    [JsonPropertyName("name")]
    public required string Nome { get; init; }
}
public sealed class PaginacaoWmResponse
{
    [JsonPropertyName("pages")]
    public required int TotalPaginas { get; init; }
    
    [JsonPropertyName("next")]
    public string? ProximaPagina { get; set; }
}