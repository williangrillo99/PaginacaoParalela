using Domain.Models;
using Refit;

namespace Infra.Http;

public interface IRickMoryApi
{
    [Get("/character/?page={page}")]
    Task<ApiResponse<ListaPersonagemResponseWm>> ListarAsync(int page, CancellationToken cancellationToken);
}