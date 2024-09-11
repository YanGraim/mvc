using Microsoft.AspNetCore.Mvc;
using mvc.Data.Repository.Interfaces;
using mvc.Models;

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

    public IActionResult AdicionarProfessor()
    {
        return View();
    }

    public IActionResult InserirProfessor(Professor professor)
    {
        try
        {
            _professorRepository.InserirProfessor(professor);
        }
        catch (Exception)
        {
            throw;
        }
        return RedirectToAction("Index");
    }
}