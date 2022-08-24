using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CIAT.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DatosPropietario> DatosPropietario { get; set; }
        public virtual DbSet<UbicacionesGanado> UbicacionesGanado { get; set; }
        public virtual DbSet<ZonasDeforestacion> ZonasDeforestacion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-3GA0E4QS\\SQLEXPRESS;Database=CIAT;User ID=admin;Password=root");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatosPropietario>(entity =>
            {
                entity.ToTable("Datos_Propietario");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCelular)
                    .IsRequired()
                    .HasColumnName("Numero_celular")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacion)
                    .IsRequired()
                    .HasColumnName("Numero_Identificacion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacion)
                    .IsRequired()
                    .HasColumnName("Tipo_Identificacion")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UbicacionesGanado>(entity =>
            {
                entity.ToTable("Ubicaciones_Ganado");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DatosPropietarioId).HasColumnName("Datos_Propietario_Id");

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoZona)
                    .IsRequired()
                    .HasColumnName("Tipo_Zona")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZonasDeforestadasId).HasColumnName("Zonas_Deforestadas_Id");

                entity.HasOne(d => d.DatosPropietario)
                    .WithMany(p => p.UbicacionesGanado)
                    .HasForeignKey(d => d.DatosPropietarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ubicaciones_Ganado_Datos_Propietario");

                entity.HasOne(d => d.ZonasDeforestadas)
                    .WithMany(p => p.UbicacionesGanado)
                    .HasForeignKey(d => d.ZonasDeforestadasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ubicaciones_Ganado_Zonas_Deforestacion");
            });

            modelBuilder.Entity<ZonasDeforestacion>(entity =>
            {
                entity.ToTable("Zonas_Deforestacion");

                entity.Property(e => e.AreaDeforestacion)
                    .IsRequired()
                    .HasColumnName("Area_Deforestacion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Latitud)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
