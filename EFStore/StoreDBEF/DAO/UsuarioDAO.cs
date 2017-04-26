using StoreDBEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDBEF.DAO
{
    public class UsuarioDAO
    {
        private EntidadesContext contexto;

        public UsuarioDAO()
        {
            contexto = new EntidadesContext();
        }
        public void SaveChanges()
        {
            contexto.SaveChanges();
        }
        public void Salva(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }

        public Usuario BuscaPorId(int id)
        {
            return contexto.Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public IList<Usuario> FindAll() {
            return contexto.Usuarios.ToList();
        }

        public void Remove(Usuario usuario)
        {
            contexto.Usuarios.Remove(usuario);
            contexto.SaveChanges();
        }
    }
}
