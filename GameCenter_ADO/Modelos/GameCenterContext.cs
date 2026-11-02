using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GameCenter_ADO.Modelos;

public partial class GameCenterContext : DbContext
{
    public GameCenterContext(DbContextOptions<GameCenterContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbVideojuegos> TbVideojuegos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbVideojuegos>(entity =>
        {
            entity.HasKey(e => e.IdVideojuego);

            entity.ToTable("Tb_Videojuegos");

            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.Genero).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Plataforma).HasMaxLength(50);
            entity.Property(e => e.Puntuacion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoCompra).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
