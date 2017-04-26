using Microsoft.Data.Entity;
using StoreDBEF.DAO;
using StoreDBEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDBEF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usuario u = new Usuario()
            //{
            //    Email = "123@123.123",
            //    Senha = "123"
            //};

            //InfoUsuario iu = new InfoUsuario()
            //{
            //    Nome = "123",
            //    Sobrenome = "De 123"
            //};
            //u.InfoUsuario = iu;

            //UsuarioDAO dao = new UsuarioDAO();
            //dao.Salva(u);
            //dao.SaveChanges();

            EntidadesContext context = new EntidadesContext();

            InfoUsuario iu2 = (from infousuario in context.InfosUsuarios
                               where infousuario.UsuarioId == 5
                               select infousuario).FirstOrDefault();

            Telefone t = new Telefone()
            {
                Numero = "4141-2331"
            };

            Telefone t2 = new Telefone()
            {
                Numero = "1123-1221"
            };
            
            iu2.Telefones.Add(t);
            iu2.Telefones.Add(t2);
            
            context.SaveChanges();

            //Deve ter o include para ele incluir a navigation property
            Usuario u2 = context.Usuarios.Include(usuario => usuario.InfoUsuario).
                ThenInclude(ius => ius.Telefones).
                FirstOrDefault(usuario => usuario.InfoUsuario.UsuarioId == 5) ;

            Endereco e = new Endereco() {
                CEP = "213123",
                Estado = "asdasd"
            };

            u2.InfoUsuario.Enderecos.Add(e);

            context.SaveChanges();

            Usuario u3 = context.Usuarios.Include(usuario => usuario.InfoUsuario).
                ThenInclude(ius3 => ius3.Telefones).
                FirstOrDefault(usuario => usuario.InfoUsuario.UsuarioId == 5);

            Console.WriteLine(
                u3.InfoUsuario.Nome + " " + u3.InfoUsuario.Sobrenome
            );

            foreach (var tel in u3.InfoUsuario.Telefones)
            {
                Console.WriteLine("Tel: " + tel.Numero);
            }
            foreach (var end in u3.InfoUsuario.Enderecos)
            {
                Console.WriteLine("Endereco: " + end.CEP + " " + end.Estado);
            }

            Console.ReadLine();
        }
    }
}
