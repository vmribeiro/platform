﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDBEF.Entidades
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }

        public int InfoUsuarioId { get; set; }
        public virtual InfoUsuario InfoUsuario { get; set; }
    }
}
