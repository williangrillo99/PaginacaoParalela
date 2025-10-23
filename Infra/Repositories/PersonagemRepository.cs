using System.Diagnostics;
using Domain;
using Domain.Interface;
using Domain.Models;
using Infra.Http;
using Refit;

namespace Infra.Repositories;

public sealed class PersonagemRepository(IRickMoryApi api) : IPersonagemRepository
{
    private readonly int _paginaInicial = 1 ;
    
    public async Task<List<Personagem>> ListarAsync(CancellationToken cancellationToken)
    {
        var response = await api.ListarAsync(_paginaInicial, cancellationToken);

        if (!response.IsSuccessful || response.Content?.Paginacao is null)
            throw new Exception("Erro ao listar do personagem");
        
        var totalPaginas = response.Content.Paginacao.TotalPaginas;
        var listaPersonagens = response.Content.Personagens;

        var tasks = new List<Task<ApiResponse<ListaPersonagemResponseWm>>>();
        
        for (var pagina = 1; pagina <= totalPaginas; pagina++)
        {
            var chamadasRestantes = api.ListarAsync(
                pagina,cancellationToken);

            tasks.AddRange(chamadasRestantes);
        }
        
        var chamadas = await Task.WhenAll(tasks);

        foreach (var chamada in chamadas)
        {
            if (!chamada.IsSuccessStatusCode || chamada.Content?.Personagens is null)
                throw new Exception("Erro ao listar do personagem");
            
            listaPersonagens.AddRange(chamada.Content.Personagens);
        }

        var retorno = MapearResponse(listaPersonagens);
        
        return retorno;
    }

    private static List<Personagem> MapearResponse(List<PersonagemReponseWm> listaPersonagensResponse)
    {
        return listaPersonagensResponse
            .Select(p => new Personagem(p.Nome))
            .ToList();
    }

    public async Task<List<Personagem>> ListarComRecursividadeAsync(int pagina, CancellationToken cancellationToken)
    {
        var response = await api.ListarAsync(pagina, cancellationToken);

        if (!response.IsSuccessful || response.Content?.Paginacao is null)
            throw new Exception("Erro ao listar do personagem");

        var retorno = MapearResponse(response.Content.Personagens);

        if (response.Content.Paginacao.ProximaPagina is null)
        {
            return retorno;
        }
        
        var itensRestantes = await ListarComRecursividadeAsync(pagina +1, cancellationToken);
        
        retorno.AddRange(itensRestantes);
        
        return retorno;
    }

}