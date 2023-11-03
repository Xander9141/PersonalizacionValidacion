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


            return View("Result");
        }

        [HttpPost]
        [Route("procesa/encuesta")]
        public IActionResult ProcesaEncuesta(string nombre, string localizacion, string lenguaje, string comentario)
        {
            TempData["Nombre"] = nombre;
            TempData["Localizacion"] = localizacion;
            TempData["Lenguaje"] = lenguaje;
            TempData["Comentario"] = comentario;

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
