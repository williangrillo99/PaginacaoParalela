namespace Domain.Interface;

public interface IPersonagemRepository
{
    Task<List<Personagem>> ListagemParalelaAsync(CancellationToken cancellationToken);
    Task<List<Personagem>> ListagemAsync(int pagina, CancellationToken cancellationToken);
}