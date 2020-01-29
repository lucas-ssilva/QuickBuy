using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    class ItemPedido : Entidade
    {
        public int ProdutoId { get; set; }
        //public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (Quantidade == 0)
            {
                AdicionarErro("Quantidade deve ser maior que zero");
            }
            if (ProdutoId == 0)
            {
                AdicionarErro("Não foi identificado qual o produto");
            }
        }
    }
}
