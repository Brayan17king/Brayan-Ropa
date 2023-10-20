using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class InsumoPrendasConfiguration : IEntityTypeConfiguration<InsumoPrenda>
{
    public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
    {
        builder.ToTable("InsumoPrendas");

        builder.HasKey(xx => new {xx.IdInsumo, xx.IdPrenda});

        builder.Property(xx => xx.IdInsumo).HasColumnType("Int");
        builder.HasOne(xx => xx.Insumos).WithMany(x => x.InsumoPrendas).HasForeignKey(xx => xx.IdInsumo);

        builder.Property(xx => xx.IdPrenda).HasColumnType("Int");
        builder.HasOne(xx => xx.Prendas).WithMany(x => x.InsumoPrendas).HasForeignKey(xx => xx.IdPrenda);
    }
}
