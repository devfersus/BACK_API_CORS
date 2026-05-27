using COREBAK.Usuario_.Entidad.Base;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.Usuario_.Entidad.DataBaseContext
{
    public class UsuarioDataBaseContext : DbContext
    {
        public UsuarioDataBaseContext(DbContextOptions<UsuarioDataBaseContext> options)
            : base(options) { }

        public DbSet<Usuario> UsuarioDBContext { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("IMB_USUARIO");
                entity.HasKey(e => e.UsuarioId);
                entity.Property(e => e.UsuarioId).HasColumnName("USUARIO_ID");
                entity.Property(e => e.NombreUsuario).HasColumnName("USUARIO");
                entity.Property(e => e.Contrasena).HasColumnName("CONTRASENA");
                entity.Property(e => e.Activo).HasColumnName("ACTIVO");
                entity.Property(e => e.Token).HasColumnName("TOKEN").IsRequired(false);
                entity.Property(e => e.TokenExpiracion).HasColumnName("TOKEN_EXPIRACION").IsRequired(false);
            });
        }
    }
}
