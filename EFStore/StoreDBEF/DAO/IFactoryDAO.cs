using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StoreDBEF.DAO
{
    public interface IFactoryDAO
    {
        UsuarioDAO GetUsuarioDAO();
    }
}