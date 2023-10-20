using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {
        builder.ToTable("Empleado");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.IdEmpleado).IsRequired().HasMaxLength(50);
        builder.HasIndex(x => x.IdEmpleado).IsUnique();

        builder.Property(x => x.NombreEmpleado).IsRequired().HasMaxLength(50);

        builder.Property(x => x.FechaIngreso).IsRequired().HasColumnType("date");
        
        builder.Property(x => x.IdCargo).IsRequired().HasColumnType("int");
        builder.HasOne(x => x.Cargos).WithMany(x => x.Empleados).HasForeignKey(x => x.IdCargo);

        builder.Property(x => x.IdMunicipio).IsRequired().HasColumnType("int");
        builder.HasOne(x => x.Municipios).WithMany(x => x.Empleados).HasForeignKey(x => x.IdMunicipio);
    }
}
