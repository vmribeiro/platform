﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDBEF.Entidades
{
    public class InfoUsuario
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }
        
        public string Sobrenome { get; set; }
        
        public string Cpf { get; set; }
        
        public string Rg { get; set; }

        public DateTime DataNascimento { get; set; }
        

        //Pertence a um Usuario
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        //Possui vários telefones
        public virtual IList<Telefone> Telefones { get; set; }

        //Possui vários endereços
        public virtual IList<Endereco> Enderecos { get; set; }

        public InfoUsuario() {
            Telefones = new List<Telefone>();
            Enderecos = new List<Endereco>();
        }

    }
}
