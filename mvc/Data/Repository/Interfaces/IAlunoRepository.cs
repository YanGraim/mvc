using mvc.Models;

namespace mvc.Data.Repository.Interfaces;

public interface IAlunoRepository
{
    List<Aluno> BuscarAlunos();
}