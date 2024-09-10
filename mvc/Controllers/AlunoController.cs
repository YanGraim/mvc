using Microsoft.AspNetCore.Mvc;
using mvc.Data.Repository.Interfaces;
using mvc.Models;

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

    public IActionResult AdicionarAluno()
    {
        return View();
    }

    public IActionResult InserirAluno(Aluno aluno)
    {
        try
        {
            _alunoRepository.InserirAluno(aluno);
        }
        catch (Exception)
        {
            throw;
        }

        return RedirectToAction("Index");
    }

    public IActionResult Editar(int id)
    {
        var aluno = _alunoRepository.BuscarId(id);
        return View(aluno);
    }

    public IActionResult EditarAluno(Aluno aluno)
    {
        _alunoRepository.EditarAluno(aluno);
        return RedirectToAction("Index");
    }
    
    public IActionResult DeletarAluno(Aluno aluno)
    {
        _alunoRepository.DeletarAluno(aluno);
        return RedirectToAction("Index");
    
    }
}