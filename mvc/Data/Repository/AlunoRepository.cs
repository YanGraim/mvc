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

    public void InserirAluno(Aluno aluno)
    {
        _bancoContext.Aluno.Add(aluno);
        _bancoContext.SaveChanges();

    }

    public Aluno BuscarId(int id)
    {
        return _bancoContext.Aluno.FirstOrDefault(x => x.Id == id);
    }

    public void EditarAluno(Aluno aluno)
    {
        _bancoContext.Aluno.Update(aluno);
        _bancoContext.SaveChanges();
    }

    public void DeletarAluno(Aluno aluno)
    {
        _bancoContext.Aluno.Remove(aluno);
        _bancoContext.SaveChanges();
    }
    
}