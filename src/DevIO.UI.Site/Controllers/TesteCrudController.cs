using System;
using System.Linq;
using DevIO.UI.Site.Data;
using DevIO.UI.Site.Models;
using DevIO.UI.Site.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Controllers
{
    public class TesteCrudController : Controller
    {

        private readonly MeuDbContext _meuDbContext;

        public TesteCrudController(MeuDbContext context)
        {
            _meuDbContext = context;
        }

        public IActionResult Index()
        {
            // Simulação de um possível formulário recebido no code-behind.
            var aluno = new Aluno
            {
                Nome = "Ramon",
                DataNascimento = DateTime.Now,
                Email = "ramon@gmail.com"
            };

            // Insert
            _meuDbContext.Alunos.Add(aluno);
            _meuDbContext.SaveChanges();

            // Select's
            var aluno2 = _meuDbContext.Alunos.Find(aluno.Id);
            var aluno3 = _meuDbContext.Alunos.FirstOrDefault(a => a.Email == "ramon@gmail.com");
            var aluno4 = _meuDbContext.Alunos.Where(a => a.Nome == "Ramon");

            // Update
            aluno.Nome = "João";
            _meuDbContext.Alunos.Update(aluno);
            _meuDbContext.SaveChanges();

            // Delete
            _meuDbContext.Alunos.Remove(aluno);
            _meuDbContext.SaveChanges();

            return View();
        }
    }
}