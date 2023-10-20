using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class InventarioProveedorConfiguration : IEntityTypeConfiguration<Inventario>
{
    public void Configure(EntityTypeBuilder<Inventario> builder)
    {
        builder.ToTable("Inventario");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.CodInventario).IsRequired().HasMaxLength(50);
        builder.HasIndex(x => x.CodInventario).IsUnique();

        builder.Property(x => x.ValorVtaCop).IsRequired().HasColumnType("double");
        builder.Property(x => x.ValorVtaUsd).IsRequired().HasColumnType("double");

        builder.Property(x => x.IdPrenda).HasColumnType("Int");
        builder.HasOne(x => x.Prendas).WithMany(x => x.Inventarios).HasForeignKey(x => x.IdPrenda);
    }
}
