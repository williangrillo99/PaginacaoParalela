namespace Domain.Interface;

public interface IPersonagemRepository
{
    Task<List<Personagem>> ListarAsync(CancellationToken cancellationToken);
    Task<List<Personagem>> ListarComRecursividadeAsync(int pagina, CancellationToken cancellationToken);
}