using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePOS.Services
{
    public interface IDataService<T>
    {
        Task<List<T>> GetAll();
        Task<T> Find(int id);
        Task<T> Store(T entity);
        Task<T> Update(int id, T entity);
        Task<bool> Delete(int id);

    }
}
