using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using MVCApp2.Models;

namespace MVCApp2.Models;

public partial class StudentsContext : DbContext
{
    public StudentsContext()
    {
    }

    public StudentsContext(DbContextOptions<StudentsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Imagetable> Imagetables { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=Shopping;Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cart");
            entity.ToTable("Cart");
            entity.Property(e => e.Id);

            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Price)
                .HasMaxLength(50)
                .IsUnicode(false);

        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Comments__B40CC6CD2D85471F");

            entity.Property(e => e.ProductId).ValueGeneratedNever();
            entity.Property(e => e.Comments).IsUnicode(false);
        });

        modelBuilder.Entity<Imagetable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__imagetab__3214EC07A6E917FC");

            entity.ToTable("imagetable");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Image)
                .IsUnicode(false)
                .HasColumnName("image");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.UserName).HasName("PK__Payment__C9F2845742FD7C1F");

            entity.ToTable("Payment");

            entity.Property(e => e.UserName).ValueGeneratedNever();
            entity.Property(e => e.CardId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07D1159C68");

            entity.ToTable("products");

            entity.Property(e => e.Id);
            entity.Property(e => e.CategoryId)
                .IsUnicode(false)
                .HasColumnName("categoryId");
            entity.Property(e => e.CategoryName)
                .IsUnicode(false)
                .HasColumnName("categoryName");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Price)
                .IsUnicode(false)
                .HasColumnName("price");
            entity.Property(e => e.ProductId)
                .IsUnicode(false)
                .HasColumnName("productId");
            entity.Property(e => e.ProductName)
                .IsUnicode(false)
                .HasColumnName("productName");
            entity.Property(e => e.Rating)
                .IsUnicode(false)
                .HasColumnName("rating");
            entity.Property(e => e.SubCategoryId)
                .IsUnicode(false)
                .HasColumnName("subCategoryId");
            entity.Property(e => e.SubCategoryName)
                .IsUnicode(false)
                .HasColumnName("subCategoryName");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Table__3214EC07D0E7603F");

            entity.ToTable("Table");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CategoryId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("categoryId");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("categoryName");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.Price)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("price");
            entity.Property(e => e.ProductId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("productId");
            entity.Property(e => e.ProductName)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("productName");
            entity.Property(e => e.Rating)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("rating");
            entity.Property(e => e.SubCategiryName)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("subCategiryName");
            entity.Property(e => e.SubCategoryId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("subCategoryId");
        });

        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.HasKey(e => e.ProductCode);

            entity.ToTable("tbl_products");

            entity.Property(e => e.ProductCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("productCode");
            entity.Property(e => e.BrandName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("brandName");
            entity.Property(e => e.ExpiryDate).HasColumnName("expiryDate");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
            entity.Property(e => e.StockLeft).HasColumnName("stockLeft");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserName).HasName("PK__Users__C9F28457FB16375D");

            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AuthType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

public DbSet<MVCApp2.Models.Login> Login { get; set; } = default!;
}
