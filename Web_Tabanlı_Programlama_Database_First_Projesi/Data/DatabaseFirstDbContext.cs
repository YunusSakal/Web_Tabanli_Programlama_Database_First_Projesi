using System;
using System.Collections.Generic;
using Web_Tabanlı_Programlama_Database_First_Projesi.Models;
using Microsoft.EntityFrameworkCore;

namespace Web_Tabanlı_Programlama_Database_First_Projesi.Data;

public partial class DatabaseFirstDbContext : DbContext
{
    public DatabaseFirstDbContext()
    {
    }

    public DatabaseFirstDbContext(DbContextOptions<DatabaseFirstDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC07F338D903");

            entity.Property(e => e.CategoryName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(200);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
