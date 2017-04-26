using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDBEF.Entidades
{
    public class Telefone
    {
        public int Id { get; set; }
        
        public string Numero { get; set; }

        public int InfoUsuarioId { get; set; }
        public virtual InfoUsuario InfoUsuario { get; set; }
    }
}
