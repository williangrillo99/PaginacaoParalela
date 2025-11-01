using Domain;
using Domain.Interface;

namespace Application.ListarPersonagem;

public class ListarPersonagemAppService(IPersonagemRepository  repository) :
    IListagemPaginacaoAppService
{
    
    public Task<List<Personagem>> PaginacaoParalelaAsync(CancellationToken cancellationToken)
    {
        var listagemAsync = repository.ListagemParalelaAsync(cancellationToken);
        
        return listagemAsync;
    }

    public Task<List<Personagem>> PaginacaoAsync(CancellationToken cancellationToken)
    {
        var listagemAsync = repository.ListagemAsync(1, cancellationToken);
        
        return listagemAsync;
    }
}