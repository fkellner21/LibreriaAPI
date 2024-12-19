using LogicaDeNegocio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.EF.Config
{
    public class TipoDeMovimientoConfiguration : IEntityTypeConfiguration<TipoDeMovimiento>
    {
        public void Configure(EntityTypeBuilder<TipoDeMovimiento> builder)
        {
            builder.HasIndex(t => t.Nombre).IsUnique();
        }
    }
}
