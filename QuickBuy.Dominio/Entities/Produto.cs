using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
   public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Produto() { }

        public Produto(int id, string nome, string descricao, double preco)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarErro("Todos os produtos devem ter nome");
            }
            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarErro("Todo produto deve ter uma descrição");
            }
            if (Preco <= 0)
            {
                AdicionarErro("Preço invalido");
            }
        }
    }
}
