using Microsoft.AspNetCore.Mvc;

namespace EncuestaDojo.Controllers
{
    public class PrincipalController : Controller
    {

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }


        [HttpGet]
        [Route("result")]
        public IActionResult Result()
        {
            ViewBag.Nombre = TempData["Nombre"];
            ViewBag.Localizacion = TempData["Localizacion"];
            ViewBag.Lenguaje = TempData["Lenguaje"];
            ViewBag.Comentario = TempData["Comentario"];

            return View("Result");
        }

        [HttpPost]
        [Route("/procesa/encuesta")]
        public IActionResult ProcesaEncuesta(Survey survey)
        {
            TempData["Nombre"] = survey.Nombre;
            TempData["Localizacion"] = survey.Localizacion;
            TempData["Lenguaje"] = survey.Lenguaje;
            TempData["Comentario"] = survey.Comentario;

            return RedirectToAction("Result");
        }



        [HttpGet]
        [Route("newIndex")]
        public IActionResult NewIndex()
        {
            return View("Index");
        }
    }
}
