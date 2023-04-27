using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteMVC1.Models;

namespace TesteMVC1.Controllers
{
    public class AlunoController : Controller
    {
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
            //Alguma regra de negocio + salvar no banco
            return View(aluno);
        }

    }
}