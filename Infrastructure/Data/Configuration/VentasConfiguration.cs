using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class VentasConfiguration : IEntityTypeConfiguration<Venta>
{
    public void Configure(EntityTypeBuilder<Venta> builder)
    {
        builder.ToTable("Ventas");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.FechaVenta).IsRequired().HasColumnType("date");

        builder.Property(x => x.IdEmpleado).HasColumnType("int");
        builder.HasOne(x => x.Empleados).WithMany(x => x.Ventas).HasForeignKey(x => x.IdEmpleado);

        builder.Property(x => x.IdCliente).HasColumnType("int");
        builder.HasOne(x => x.Clientes).WithMany(x => x.Ventas).HasForeignKey(x => x.IdCliente);

        builder.Property(x => x.IdFormaPago).HasColumnType("int");
        builder.HasOne(x => x.FormaPagos).WithMany(x => x.Ventas).HasForeignKey(x => x.IdFormaPago);
    }
}
