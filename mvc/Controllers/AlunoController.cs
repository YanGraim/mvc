using Microsoft.AspNetCore.Mvc;
using mvc.Data.Repository.Interfaces;

namespace mvc.Controllers;

public class AlunoController : Controller
{
    private readonly IAlunoRepository _alunoRepository;
    public AlunoController(IAlunoRepository alunoRepository)
    {
        _alunoRepository = alunoRepository;
    }
    public IActionResult Index()
    {
        var aluno = _alunoRepository.BuscarAlunos();
        return View(aluno);
    }
    public IActionResult InserirAluno()
    {
        return View();       
    }
}