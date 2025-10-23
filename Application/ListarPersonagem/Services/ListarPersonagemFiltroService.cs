using Application.ListarPersonagem.Services.Interface;
using Domain;

namespace Application.ListarPersonagem.Services;

public class ListarPersonagemFiltroService : IListarPersonagemFiltroService
{
    public List<Personagem> Filtro(List<Personagem> personagems)
    {
        var query = personagems.AsQueryable();
        
        return query.ToList();
    }

    
}