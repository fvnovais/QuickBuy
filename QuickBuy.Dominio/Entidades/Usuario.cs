using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario
    {
        public int id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        /// <summary>
        /// Um Usuário pode ter nenhum ou mais pedidos
        /// </summary>

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
