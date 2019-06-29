using Junio28.Junio21;
using Junio28.Dal;
using Junio28.Controllers;
using Junio28.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio28.Dal
{
    public class CiudadDal
    {
        public static List<Ciudades> Listar()
        {
            var l = new List<Ciudades>();
            using (var db = new Model2())
            {
                l = db.Ciudades.Include("Paises").ToList();
            }
            return l;
        }
    }
}