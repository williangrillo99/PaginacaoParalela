using Application.ListarPersonagem;
using Domain;

namespace Application;

public interface IListagemPaginacaoAppService
{
    Task<List<Personagem>> PaginacaoParalelaAsync(CancellationToken cancellationToken);
    Task<List<Personagem>> PaginacaoAsync(CancellationToken cancellationToken);

}