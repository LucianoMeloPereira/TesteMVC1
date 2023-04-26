using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace TesteMVC1.Controllers
{
    [RoutePrefix("testes")]
    public class TesteController : Controller
    {
        [Route("{id:int}/{texto:maxlength(20)}")]
        public ViewResult IndexTeste(int id, string texto)
        {
            return View();
        }

        [Route("um-outro-teste")]
        public ViewResult IndexTeste2()
        {
            return View("IndexTeste");
        }
    }
}