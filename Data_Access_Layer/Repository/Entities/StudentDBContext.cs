using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Data_Access_Layer.Repository.Entities;

public partial class StudentDBContext : DbContext
{
    public StudentDBContext()
    {
    }

    public StudentDBContext(DbContextOptions<StudentDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<St> Sts { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ANAMIKA\\SQLSERVER;Database=PracticeDatabase;Trusted_Connection=True;TrustServerCertificate=true")
        .LogTo(Console.WriteLine);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dept>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__dept__3213E83F405401E6");

            entity.ToTable("dept");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<St>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("st");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.Role).HasDefaultValueSql("(N'')");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
