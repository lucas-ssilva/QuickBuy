using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities;

namespace QuickBuy.Repository.Config
{
    class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CEP).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Cidade).IsRequired().HasMaxLength(50);
            builder.Property(x => x.EndereçoCompleto).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Estado).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Numero).IsRequired().HasMaxLength(50);
            builder.Property(x => x.DataPrevisaoEntrega).IsRequired();
            builder.Property(x => x.DataPedido).IsRequired();

        }
    }
}
