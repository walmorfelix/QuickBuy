﻿using QuickBuy.Dominio.Entidades;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Contratos
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        /// <summary>
        /// Um usuário pode ter nenhum ou muitos pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
