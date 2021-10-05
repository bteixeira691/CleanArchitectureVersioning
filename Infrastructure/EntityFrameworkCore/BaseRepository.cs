using Domain.TodoItem;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityFrameworkCore
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {

        private readonly MyProjectNameDbContext context;
        private readonly DbSet<T> dbSet;


        public BaseRepository(MyProjectNameDbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
           return  dbSet.ToList();
        }

        public async Task Insert(T entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }
    }
}
