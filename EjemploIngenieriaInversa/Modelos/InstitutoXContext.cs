using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EjemploIngenieriaInversa.Modelos
{
    public partial class InstitutoXContext : DbContext
    {
        public InstitutoXContext()
        {
        }

        public InstitutoXContext(DbContextOptions<InstitutoXContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<MateriaCursadum> MateriaCursada { get; set; }
        public virtual DbSet<Materium> Materia { get; set; }
        public virtual DbSet<Pepe> Pepes { get; set; }
        public virtual DbSet<Prueba> Pruebas { get; set; }
        public virtual DbSet<Telefono> Telefonos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.1.253;Database=Instituto X;User=Pepe;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.Ci);

                entity.ToTable("Estudiante");

                entity.Property(e => e.Ci)
                    .ValueGeneratedNever()
                    .HasColumnName("ci");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FechaNac)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nac");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<MateriaCursadum>(entity =>
            {
                entity.HasKey(e => e.IdMC)
                    .HasName("PK__materia___6C8AC5CFA65C1462");

                entity.ToTable("materia_cursada", "desarrollo");

                entity.Property(e => e.IdMC).HasColumnName("id_m_c");

                entity.Property(e => e.Calificacion)
                    .HasColumnType("decimal(13, 1)")
                    .HasColumnName("calificacion");

                entity.Property(e => e.IdEst).HasColumnName("idEst");

                entity.Property(e => e.IdMat)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("idMat");

                entity.HasOne(d => d.IdEstNavigation)
                    .WithMany(p => p.MateriaCursada)
                    .HasForeignKey(d => d.IdEst)
                    .HasConstraintName("fk_materiacursada_estudiante");

                entity.HasOne(d => d.IdMatNavigation)
                    .WithMany(p => p.MateriaCursada)
                    .HasForeignKey(d => d.IdMat)
                    .HasConstraintName("fk_materiacursada_materia");
            });

            modelBuilder.Entity<Materium>(entity =>
            {
                entity.HasKey(e => e.Sigla)
                    .HasName("PK__materia__3C47D51841036B12");

                entity.ToTable("materia", "desarrollo");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sigla");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Pepe>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Valor1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("valor1");

                entity.Property(e => e.Valor2).HasColumnName("valor2");
            });

            modelBuilder.Entity<Prueba>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("prueba");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Valor1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("valor1");

                entity.Property(e => e.Valor2).HasColumnName("valor2");
            });

            modelBuilder.Entity<Telefono>(entity =>
            {
                entity.HasKey(e => e.IdTelefono);

                entity.ToTable("Telefono");

                entity.Property(e => e.IdTelefono).HasColumnName("idTelefono");

                entity.Property(e => e.CodigoEst).HasColumnName("codigoEst");

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.HasOne(d => d.CodigoEstNavigation)
                    .WithMany(p => p.Telefonos)
                    .HasForeignKey(d => d.CodigoEst)
                    .HasConstraintName("FK_Telefono_Estudiante");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
