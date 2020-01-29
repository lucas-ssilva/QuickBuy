using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Dominio.Entities
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioID { get; set; }
        //public Usuario usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string EndereçoCompleto { get; set; }
        public int Numero { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
