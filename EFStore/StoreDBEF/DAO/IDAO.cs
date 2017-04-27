using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDBEF.DAO
{
    internal interface IDAO<E>
    {
        bool SaveChanges();
        bool Salva(E e);
        E BuscaPorId(int Id);
        IList<E> FindAll();
        bool Remove(E e);
    }
}
