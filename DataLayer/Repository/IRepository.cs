using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetItems();
        T GetItem(int id);
        T Add(T item);
        T Update(T item);
        T Delete(T item);

    }
}
