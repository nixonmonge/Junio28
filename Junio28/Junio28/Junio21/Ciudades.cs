namespace Junio28.Junio21
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ciudades
    {
        [Key]
        public int CiudadId { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public int? PaisId { get; set; }

        public virtual Paises Paises { get; set; }
    }
}
