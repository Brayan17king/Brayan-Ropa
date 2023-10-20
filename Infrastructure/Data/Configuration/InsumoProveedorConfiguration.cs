using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class InsumoProveedorConfiguration : IEntityTypeConfiguration<InsumoProveedor>
{
    public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
    {
        builder.ToTable("InsumoProveedor");

        builder.HasKey(xx => new {xx.IdInsumo, xx.IdProveedor});

        builder.Property(xx => xx.IdInsumo).HasColumnType("Int");
        builder.HasOne(xx => xx.Insumos).WithMany(x => x.InsumoProveedores).HasForeignKey(xx => xx.IdInsumo);

        builder.Property(xx => xx.IdProveedor).HasColumnType("Int");
        builder.HasOne(xx => xx.Proveedores).WithMany(x => x.InsumoProveedores).HasForeignKey(xx => xx.IdProveedor);
    }
}
