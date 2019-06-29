namespace Junio28.Junio21
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ciudades>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Paises>()
                .Property(e => e.Nombre)
                .IsUnicode(false);
        }
    }
}
