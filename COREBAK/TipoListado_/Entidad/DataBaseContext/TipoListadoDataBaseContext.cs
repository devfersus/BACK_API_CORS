using COREBAK.TipoListado_.Entidad.Base;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.TipoListado_.Entidad.DataBaseContext
{
    public class TipoListadoDataBaseContext : DbContext
    {
        public TipoListadoDataBaseContext(DbContextOptions<TipoListadoDataBaseContext> options)
            : base(options) { }

        public DbSet<TipoListado> TipoListadoDBContext { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoListado>(entity =>
            {
                entity.ToTable("IMB_TIPO_LISTADO");
                entity.HasKey(e => e.TipoListadoId);
                entity.Property(e => e.TipoListadoId).HasColumnName("TIPO_LISTADO_ID");
                entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");
                entity.Property(e => e.Activo).HasColumnName("ACTIVO");
                entity.Property(e => e.FechaRegistro).HasColumnName("FECHA_REGISTRO");
                entity.Property(e => e.UsuarioRegistro).HasColumnName("USUARIO_REGISTRO");
            });
        }
    }
}
