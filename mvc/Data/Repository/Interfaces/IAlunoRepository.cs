using mvc.Models;

namespace mvc.Data.Repository.Interfaces;

public interface IAlunoRepository
{
    List<Aluno> BuscarAlunos();
    void InserirAluno(Aluno aluno);
    Aluno BuscarId(int id);
    void EditarAluno(Aluno aluno);
    void DeletarAluno(Aluno aluno);
}