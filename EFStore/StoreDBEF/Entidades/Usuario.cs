using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDBEF.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        
        public string Email { get; set; }
        
        public string Senha { get; set; }
        
        public int Tipo { get; set; }

        //Um usuario possui informações
        public virtual InfoUsuario InfoUsuario { get; set; }
    }
}
