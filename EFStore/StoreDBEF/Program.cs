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
            Usuario u = new Usuario() {
                Email = "123@123.123",
                Senha = "123"
            };

            InfoUsuario iu = new InfoUsuario() {
                Nome = "123",
                Sobrenome = "De 123"
            };

            Telefone t = new Telefone() {
                Numero = "4141-2331"
            };

            Telefone t2 = new Telefone()
            {
                Numero = "1123-1221"
            };

            u.InfoUsuario = iu;

            UsuarioDAO dao = new UsuarioDAO();
            //dao.Salva(u);
            //dao.SaveChanges();

            EntidadesContext context = new EntidadesContext();

            InfoUsuario iu2 = (from infousuario in context.InfosUsuarios
                               where infousuario.UsuarioId == 4
                              select infousuario).FirstOrDefault();

            iu2.Telefones.Add(t);
            iu2.Telefones.Add(t2);
            
            
            context.SaveChanges();


        }
    }
}
