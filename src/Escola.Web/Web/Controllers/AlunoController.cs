using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno aluno = new Aluno();

            aluno.Nome = "Eduardo Henrique";
            aluno.Idade = 21;
            aluno.Matricula = "123456";
            aluno.Cpf = "123.456.789-10";

            return View(aluno);
        }
    }
}
