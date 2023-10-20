using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class InsumosConfiguration : IEntityTypeConfiguration<Insumo>
{
    public void Configure(EntityTypeBuilder<Insumo> builder)
    {
        builder.ToTable("Insumos");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.NombreInsumo).IsRequired().HasMaxLength(50);
        builder.Property(x => x.ValorUnitario).IsRequired().HasColumnType("double");
        builder.Property(x => x.StockMin).IsRequired().HasColumnType("int");
        builder.Property(x => x.StockMax).IsRequired().HasColumnType("int");

    }
}
