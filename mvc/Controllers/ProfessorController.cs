using Microsoft.AspNetCore.Mvc;
using mvc.Data.Repository.Interfaces;

namespace mvc.Controllers;

public class ProfessorController : Controller
{
    private readonly IProfessorRepository _professorRepository;

    public ProfessorController(IProfessorRepository professorRepository)
    {
        _professorRepository = professorRepository;
    }

    public IActionResult Index()
    {
        var professor = _professorRepository.BuscarProfessores();
        return View(professor);
    }
}