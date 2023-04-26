using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteMVC1.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("sobre-nos")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("Institucional/entre-em-contato")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("Content-result")]
        public ActionResult ContentResult()
        {
            return Content("Olá!");
        }
        [Route("downloads/meu-arquivo")]
        public FileContentResult FileContentResult()
        {
            //Mapeando a pasta onde possui a foto
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/content/images/capa.png"));
            //Retornando a foto para isso retorno a pasta, o tipo do documento texto, video, imagem etc e o tipo  "png, pdf, mp4 etc
            //e o nome do arquivo com o tipo dele capa.png, video.mp4, documentoPdf.pdf etc"
            return File(foto, "image/png", "capa.png");
        }
        public HttpUnauthorizedResult HttpUnauthorizedResult()
        {
            return new HttpUnauthorizedResult();
        }
        public JsonResult JsonResult()
        {
            return Json("nome: 'Luciano'", JsonRequestBehavior.AllowGet);
        }
        public RedirectResult RedirectResult()
        {
            return new RedirectResult("https://desenvolvedor.io");
        }
        public RedirectToRouteResult RedirectToRouteResult()
        {
            return RedirectToRoute(new
            {
                controller = "Teste",
                action = "IndexTeste"
            });
            //return RedirectToAction("IndexTeste, Teste ");
        }
    }
}