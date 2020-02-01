using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Dominio.Entities
{
  public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string EndereçoCompleto { get; set; }
        public int Numero { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagens();

            if(!ItensPedido.Any())
            {
               AdicionarErro("Pedido deve ter pelo menos um item");
            }
            if (string.IsNullOrEmpty(CEP))
            {
               AdicionarErro("Campo CEP é obrigatorio");
            }
            if (string.IsNullOrEmpty(EndereçoCompleto))
            {
                AdicionarErro("Campos do Endereço são obrigatorios");
            }
            if (FormaPagamentoId == 0)
            {
                AdicionarErro("Não foram selecionadas formas de pagamento");
            }
        }
    }
}
