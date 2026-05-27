using COREBAK.PropiedadDetalle_.Entidad.Base;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.PropiedadDetalle_.Entidad.DataBaseContext
{
    public class PropiedadDetalleDataBaseContext : DbContext
    {
        public PropiedadDetalleDataBaseContext(DbContextOptions<PropiedadDetalleDataBaseContext> options)
            : base(options) { }

        public DbSet<PropiedadDetalle> PropiedadDetalleDBContext { get; set; }
        public DbSet<PropiedadDetalleFoto> PropiedadDetalleFotoDBContext { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PropiedadDetalle>(entity =>
            {
                entity.ToTable("IMB_PROPIEDAD_DETALLE");
                entity.HasKey(e => e.PropiedadListadoId);
                entity.Property(e => e.PropiedadListadoId).HasColumnName("PROPIEDAD_LISTADO_ID");
                entity.Property(e => e.TipoPropiedadId).HasColumnName("TIPO_PROPIEDAD_ID");
                entity.Property(e => e.TipoListadoId).HasColumnName("TIPO_LISTADO_ID");
                entity.Property(e => e.Titulo).HasColumnName("TITULO");
                entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");
                entity.Property(e => e.Precio).HasColumnName("PRECIO");
                entity.Property(e => e.ContadorClicks).HasColumnName("CONTADOR_CLICKS");
                entity.Property(e => e.CodigoPromocionId).HasColumnName("CODIGO_PROMOCION_ID");
                entity.Property(e => e.Activo).HasColumnName("ACTIVO");
                entity.Property(e => e.DepartamentoId).HasColumnName("DEPARTAMENTO_ID");
                entity.Property(e => e.DescripcionFinal).HasColumnName("DESCRIPCION_FINAL");
                entity.Property(e => e.Orden).HasColumnName("ORDEN");
                entity.Property(e => e.Ubicacion).HasColumnName("UBICACION");
                entity.Property(e => e.AreaTerreno).HasColumnName("AREA_TERRENO");
                entity.Property(e => e.TipoMoneda).HasColumnName("TIPO_MONEDA").HasMaxLength(5);

                entity.HasMany(e => e.Fotos)
                    .WithOne()
                    .HasForeignKey(f => f.PropiedadListadoId)
                    .IsRequired(false)
                    .HasConstraintName("FK_IMB_PROPIEDAD_DETALLE_FOTO_PROPIEDAD");
            });

            modelBuilder.Entity<PropiedadDetalleFoto>(entity =>
            {
                entity.ToTable("PROPIEDAD_DETALLE_FOTOS");
                entity.HasKey(e => e.PropiedadDetalleFotos);
                entity.Property(e => e.PropiedadDetalleFotos).HasColumnName("PROPIEDAD_DETALLE_FOTOS");
                entity.Property(e => e.PropiedadListadoId).HasColumnName("PROPIEDAD_LISTADO_ID");
                entity.Property(e => e.Foto).HasColumnName("FOTO");
                entity.Property(e => e.Activo).HasColumnName("ACTIVO");
                entity.Property(e => e.Orden).HasColumnName("ORDEN");
            });
        }
    }
}