using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TodoItem
{
   public interface IRepository<T> where T : class
    {
        Task Insert(T entity);
        Task<IEnumerable<T>> GetAll();
    }
}
