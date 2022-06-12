using System.Collections.Generic;

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
