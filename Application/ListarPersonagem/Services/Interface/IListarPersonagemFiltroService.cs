using Domain;

namespace Application.ListarPersonagem.Services.Interface;

public interface IListarPersonagemFiltroService
{
    List<Personagem> Filtro(List<Personagem> pernagens);
}