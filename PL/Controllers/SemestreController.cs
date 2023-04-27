using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class SemestreController : Controller
    {
        public ActionResult GetAll()
        {
            ML.Semestre semestre = new ML.Semestre();

            ML.Result result = BL.Semestre.GetAll();

            if (result.Correct)
            {
                semestre.Semestres = result.Objects;
                return View(semestre);
            }
            else
            {
                ViewBag.Message = "Ocurrio un error en la consulta";
                return View();
            }
            
        }
    }
}
