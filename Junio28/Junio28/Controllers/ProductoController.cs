using Junio28.Dal;
using Junio28.Controllers;
using Junio28.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Junio28.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Insertar()
        {
            var model = new Producto();
            return View(model);
        }
        [HttpPost]
        public ActionResult Insertar(Producto model)
        {
            ProductoDal.Insertar(model);
            return View(model);
        }

        public ActionResult Listar()
        {
            // viwBag
            // ViwData
            // Model = Formulario (solo puede ser uno)
            ViewData["productos"] = ProductoDal.Listar();

            return View();
        }




    }
}