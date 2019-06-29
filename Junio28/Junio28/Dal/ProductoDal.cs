using Junio28.Dal;
using Junio28.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio28.Dal
{
    public class ProductoDal
    {
        public static List<Producto> Listar()
        {
            var l = new List<Producto>();
            using (var db=new Model1())
            {
                l = db.Producto.ToList();
            }
            return l;
        }
    }
}