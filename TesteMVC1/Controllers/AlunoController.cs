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
        [Route("novo-aluno")]
        public ActionResult Novo(Aluno aluno)
        {
            aluno = new Aluno
            {
                Id= 1,
                Nome = "Luciano",
                CPF = "12345678945",
                DataMatricula = DateTime.Now,
                Email = "luciano.melo@gmail.com",
                Ativo = true
            };

            //Redirecionando o resultado aluno desta action para action Index
            return RedirectToAction("Index", aluno);
        }

        //Passando o aluno como um dado no parametro da action Index
        public ActionResult Index(Aluno aluno)
        {   
            //Está sendo validado pelo modelState " se estado da model não for valida mostre o aluno com os dataNottations
            //requerindo os dados corretos e se estiver tudo ok, mostre o aluno
            if(!ModelState.IsValid) return View(aluno);

            return View(aluno);
        }
    }
}