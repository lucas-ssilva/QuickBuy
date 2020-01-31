using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities;

namespace QuickBuy.Repository.Config
{
    class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Nome).IsRequired().HasMaxLength(30);
            builder.Property(u => u.Sobrenome).IsRequired().HasMaxLength(30);
            builder.Property(u => u.Senha).IsRequired();

            builder.HasMany(u => u.Pedidos).WithOne(p => p.Usuario);

        }
    }
}
