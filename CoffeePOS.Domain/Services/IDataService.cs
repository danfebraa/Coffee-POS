using CoffeePOS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePOS.Domain.Services
{
    public interface IDataService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Find(int id);
        Task<T> Store(T entity);
        Task<T> Update(int id, T entity);
        Task<bool> Delete(int id);

    }
}
