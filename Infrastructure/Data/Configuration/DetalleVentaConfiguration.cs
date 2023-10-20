using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
{
    public void Configure(EntityTypeBuilder<DetalleVenta> builder)
    {
        builder.ToTable("DetalleVenta");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.Cantidad).IsRequired().HasColumnType("int");
        builder.Property(x => x.ValorUnitario).IsRequired().HasColumnType("double");
        builder.Property(x => x.MyProperty).IsRequired().HasColumnType("int");

        builder.Property(x => x.IdTalla).HasColumnType("int");
        builder.HasOne(x => x.Tallas).WithMany(x => x.DetalleVentas).HasForeignKey(x => x.IdTalla);

        builder.Property(x => x.IdVenta).HasColumnType("int");
        builder.HasOne(x => x.Ventas).WithMany(x => x.DetalleVentas).HasForeignKey(x => x.IdVenta);

        builder.Property(x => x.IdInventario).HasColumnType("int");
        builder.HasOne(x => x.Inventarios).WithMany(x => x.DetalleVentas).HasForeignKey(x => x.IdInventario);


    }
}
