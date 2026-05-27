using COREBAK.CodigoPromocion_.Entidad.Base;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.CodigoPromocion_.Entidad.DataBaseContext
{
    public class CodigoPromocionDataBaseContext : DbContext
    {
        public CodigoPromocionDataBaseContext(DbContextOptions<CodigoPromocionDataBaseContext> options)
            : base(options) { }

        public DbSet<CodigoPromocion> CodigoPromocionDBContext { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CodigoPromocion>(entity =>
            {
                entity.ToTable("IMB_CODIGO_PROMOCIONES");
                entity.HasKey(e => e.CodigoPromocionId);
                entity.Property(e => e.CodigoPromocionId).HasColumnName("CODIGO_PROMOCION_ID");
                entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");
                entity.Property(e => e.Activo).HasColumnName("ACTIVO");
                entity.Property(e => e.FechaRegistro).HasColumnName("FECHA_REGISTRO");
                entity.Property(e => e.UsuarioRegistro).HasColumnName("USUARIO_REGISTRO");
            });
        }
    }
}
