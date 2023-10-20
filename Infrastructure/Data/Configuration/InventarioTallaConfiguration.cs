using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
{
    public void Configure(EntityTypeBuilder<InventarioTalla> builder)
    {
        builder.ToTable("InventarioTalla");

        builder.Property(x => x.Cantidad).IsRequired().HasColumnType("int");

        builder.HasKey(xx => new { xx.IdInventario, xx.IdTalla });

        builder.Property(xx => xx.IdInventario).HasColumnType("Int");
        builder.HasOne(xx => xx.Inventarios).WithMany(x => x.InventarioTallas).HasForeignKey(xx => xx.IdInventario);

        builder.Property(xx => xx.IdTalla).HasColumnType("Int");
        builder.HasOne(xx => xx.Tallas).WithMany(x => x.InventarioTallas).HasForeignKey(xx => xx.IdTalla);
    }
}
