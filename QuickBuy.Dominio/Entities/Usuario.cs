using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
   public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

        public Usuario() { }

        public Usuario(int id, string email, string senha, string nome, string sobrenome)
        {
            Id = id;
            Email = email;
            Senha = senha;
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AdicionarErro("Campo E-mail é Obrigatorio");
            }
            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarErro("CAmpo senha é obrigatorio");
            }
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarErro("Campo {0} é obrigatorio");
            }
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarErro("Campo Sobrenome é obrigatorio");
            }
        }
    }
}
