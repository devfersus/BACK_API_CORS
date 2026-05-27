using COREBAK.TipoPropiedad_.Entidad.Base;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.TipoPropiedad_.Entidad.DataBaseContext
{
    public class TipoPropiedadDataBaseContext : DbContext
    {
        public TipoPropiedadDataBaseContext(DbContextOptions<TipoPropiedadDataBaseContext> options)
            : base(options)
        {
        }
        public DbSet<TipoPropiedad> TipoPropiedadDBContext { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TipoPropiedad>(entity =>
            {
                entity.ToTable("IMB_TIPO_PROPIEDAD");

                entity.HasKey(u => u.TipoPropiedadId);
                entity.Property(u => u.TipoPropiedadId)
                    .HasColumnName("TIPO_PROPIEDAD_ID")
                    .HasColumnType("UNIQUEIDENTIFIER")
                    .IsRequired();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(50)
                    .IsRequired();

                entity.Property(e => e.Activo)
                    .HasColumnName("ACTIVO")
                    .IsRequired();

                entity.Property(e => e.UsuarioRegistro)
                    .HasColumnName("USUARIO_REGISTRO")
                    .HasMaxLength(10);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("FECHA_REGISTRO")
                    .HasColumnType("DATETIME")
                    .IsRequired();
            });
        }
    }
}