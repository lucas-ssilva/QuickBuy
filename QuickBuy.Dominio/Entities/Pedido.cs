using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioID { get; set; }
        //public Usuario usuario { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
