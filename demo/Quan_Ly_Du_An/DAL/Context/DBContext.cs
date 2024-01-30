using System;
using System.Collections.Generic;
using DAL.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<DonHang> DonHangs { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= DESKTOP-ENR7G5Q ;Initial Catalog= Quan_ly_Agile;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Admin__3214EC278B16368D");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DonHang__3214EC27E925BD8B");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IddonhangNavigation).WithMany(p => p.DonHangs).HasConstraintName("FK__DonHang__IDDONHA__6FE99F9F");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__KhachHan__3214EC27A4CE6735");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdadminNavigation).WithMany(p => p.KhachHangs).HasConstraintName("FK__KhachHang__IDAdm__48CFD27E");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NhanVien__3213E83F4D09CB55");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Admin).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__AdminI__4BAC3F29");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SANPHAM__3213E83FCA00BD95");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNccNavigation).WithMany(p => p.Sanphams).HasConstraintName("FK__SANPHAM__idNCC__4E88ABD4");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
