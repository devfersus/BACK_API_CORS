using COREBAK.Departamento_.Entidad.Base;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.Departamento_.Entidad.DataBaseContext
{
    public class DepartamentoDataBaseContext : DbContext
    {
        public DepartamentoDataBaseContext(DbContextOptions<DepartamentoDataBaseContext> options)
            : base(options) { }

        public DbSet<Departamento> DepartamentoDBContext { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.ToTable("IMB_DEPARTAMENTO");

                entity.HasKey(e => e.DepartamentoId);

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("DEPARTAMENTO_ID")
                    .HasColumnType("int")
                    .IsRequired();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(100);

                entity.Property(e => e.Activo)
                    .HasColumnName("ACTIVO");
            });
        }
    }
}
