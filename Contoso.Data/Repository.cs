using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly IDbSet<T> dbSet;
        protected ContosoDbContext _context;
        public Repository(ContosoDbContext context)
        {
            _context = context;
            dbSet = context.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.AsNoTracking().ToList(); //AsNottracking improve
        }

        public T GetById(int Id)
        {
            return dbSet.Find(Id);
        }

        public IQueryable<T> GetQueryable()
        {
            return dbSet.AsQueryable<T>();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
