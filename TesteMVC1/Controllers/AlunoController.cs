using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteMVC1.Data;
using TesteMVC1.Models;

namespace TesteMVC1.Controllers
{
    public class AlunoController : Controller
    {
        private readonly AppDbContext context = new AppDbContext();

        [HttpGet]
        [Route("novo-aluno")]
        public ActionResult NovoAluno()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("novo-aluno")]
        public ActionResult NovoAluno(Aluno aluno)
        {
            if (!ModelState.IsValid);
            aluno.DataMatricula = DateTime.Now;
            context.Alunos.Add(aluno);
            context.SaveChanges();

            return View(aluno);
        }

        [HttpGet]
        [Route("obter-alunos")]
        public ActionResult ObterAlunos()
        {
            var alunos = context.Alunos.ToList(); 
            return View("NovoAluno", alunos.FirstOrDefault());
        }

        [HttpGet]
        [Route("editar-aluno")]
        public ActionResult EditarAluno()
        {
            var aluno = context.Alunos.FirstOrDefault(a => a.Nome == "Luciano Melo Pereira");
            aluno.Nome = "Jonatas Oliveiro";
            var entry = context.Entry(aluno);
            context.Set<Aluno>().Attach(aluno);
            entry.State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            var alunoNovo = context.Alunos.Find(aluno.Id);
            return View("NovoAluno", alunoNovo);
        }

        [HttpGet]
        [Route("excluir-aluno")]
        public ActionResult ExcluirAluno()
        {
            var aluno = context.Alunos.FirstOrDefault(a => a.Nome == "Jonatas Oliveiro");

            context.Alunos.Remove(aluno);
            context.SaveChanges();
            var alunos = context.Alunos.ToList();
            return View("NovoAluno", alunos.First());
        }
    }
}