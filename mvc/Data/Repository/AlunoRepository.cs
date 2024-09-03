using mvc.Data.Repository.Interfaces;
using mvc.Models;

namespace mvc.Data.Repository;

public class AlunoRepository : IAlunoRepository
{

    private readonly BancoContext _bancoContext;

    public AlunoRepository(BancoContext bancoContext)
    {
        _bancoContext = bancoContext;
    }

    public List<Aluno> BuscarAlunos()
    {
        return _bancoContext.Aluno.ToList();
    }
}