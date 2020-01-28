using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    class Usuario
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
    }
}
