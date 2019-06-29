using Junio28.Junio21;
using Junio28.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Junio28.Controllers
{
    public class CiudadController : Controller
    {
        // GET: Ciudad
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listar()
        {
            // viwBag
            // ViwData
            // Model = Formulario (solo puede ser uno)
            ViewData["ciudad"] = CiudadDal.Listar();

            return View();
        }
    }
}