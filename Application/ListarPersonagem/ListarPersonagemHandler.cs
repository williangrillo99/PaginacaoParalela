using System.Diagnostics;
using Domain;
using Domain.Interface;
using MediatR;

namespace Application.ListarPersonagem;

public class ListarPersonagemHandler(IPersonagemRepository  repository) : 
    IRequestHandler<ListarPersonagemQuery, List<Personagem>>
{
    public async Task<List<Personagem>> Handle(ListarPersonagemQuery request, 
        CancellationToken cancellationToken)
    {
        var sw = Stopwatch.StartNew(); // ⏱ inicia cronômetro

        var retorno = await repository.ListarAsync(cancellationToken);
        
        sw.Stop();
        
        var ssw = Stopwatch.StartNew(); 
        
        ssw.Start();
        var retorno2 = await repository.ListarComRecursividadeAsync(1,cancellationToken);
        ssw.Stop();

        return retorno;
    }
}