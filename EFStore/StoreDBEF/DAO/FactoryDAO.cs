using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDBEF.DAO
{
    internal class FactoryDAO : IFactoryDAO
    {
        public UsuarioDAO GetUsuarioDAO()
        {
            return new UsuarioDAO();
        }
    }
}
