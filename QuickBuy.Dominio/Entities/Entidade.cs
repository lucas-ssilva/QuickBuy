using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
  public abstract class Entidade
    {
        private List<string> _mensagensvalidacao { get; set; }
        private List<string> MensagemValidacao
        {
            get { return _mensagensvalidacao ?? (_mensagensvalidacao = new List<string>()); }
        }
        public abstract void Validate();
        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); } 
        }
        protected void LimparMensagens()
        {
            MensagemValidacao.Clear();
        }
        protected void AdicionarErro(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

    }
}
