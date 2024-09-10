using mvc.Data.Repository.Interfaces;
using mvc.Models;

namespace mvc.Data.Repository;

public class ProfessorRepository : IProfessorRepository
{
    private readonly BancoContext _bancoContext;

    public ProfessorRepository(BancoContext bancoContext)
    {
        _bancoContext = bancoContext;
    }

    public List<Professor> BuscarProfessores()
    {
        return _bancoContext.Profesor.ToList();
    }
}