using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Dominio.Enums;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamento.Boleto; }
        }

        public bool Ehcartao
        {
            get { return Id == (int)TipoFormaPagamento.Credito; }
        }
        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamento.Deposito; }
        }
        public bool NaoDefinido
        {
            get { return Id == (int)TipoFormaPagamento.NaoDefinido; }
        }
    }
}
