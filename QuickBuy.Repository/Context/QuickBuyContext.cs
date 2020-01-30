using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entities;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repository.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Context
{
   public class QuickBuyContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamentos { get; set; }

        public QuickBuyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //referencia as classes de mapeamento 
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
