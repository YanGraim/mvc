using mvc.Models;

namespace mvc.Data.Repository.Interfaces;

public interface IProfessorRepository{

    List<Professor> BuscarProfessores();
    void InserirProfessor(Professor professor);
}