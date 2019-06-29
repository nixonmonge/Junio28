namespace Junio28.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        public int ProductoId { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public int? Precio { get; set; }
    }
}
