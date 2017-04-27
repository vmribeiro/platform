using StoreDBEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDBEF.DAO
{
    public class UsuarioDAO : IDAO<Usuario>
    {
        private EntidadesContext contexto;

        public UsuarioDAO()
        {
            contexto = new EntidadesContext();
        }
        
        public Usuario BuscaPorId(int id)
        {
            return contexto.Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public IList<Usuario> FindAll() {
            return contexto.Usuarios.ToList();
        }
        
        bool IDAO<Usuario>.SaveChanges()
        {
            try
            {
                contexto.SaveChanges();
                return true;
            }
            catch (Exception saveChangesEx)
            {
                Console.WriteLine(saveChangesEx.Message);
                return false;
            }            
        }

        bool IDAO<Usuario>.Salva(Usuario e)
        {
            try
            {
                contexto.Usuarios.Add(e);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception saveEx)
            {
                Console.WriteLine(saveEx.Message);
                return false;
            }
        }

        bool IDAO<Usuario>.Remove(Usuario e)
        {
            try
            {
                contexto.Usuarios.Remove(e);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception removeEx)
            {
                Console.WriteLine(removeEx.Message);
                return false;
            }
        }
    }
}
