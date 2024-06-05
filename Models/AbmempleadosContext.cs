using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ABMEmpleados.Models;

public partial class AbmempleadosContext : DbContext
{
    public AbmempleadosContext()
    {
    }

    public AbmempleadosContext(DbContextOptions<AbmempleadosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empleados> Empleados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
        
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseSqlServer("Server=localhost; database=ABMEmpleados; TrustServerCertificate=True; integrated security=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleados>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Empleado__3214EC078B98B761");

            entity.Property(e => e.Apellido)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Puesto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(12)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
