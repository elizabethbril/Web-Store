using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Database
{
    public class ContextRepository<TEntity>:IGenericRepository<TEntity> where TEntity:class
    {
        private readonly ShopContext context;
        private readonly DbSet<TEntity> dbSet;
        public ContextRepository(ShopContext _context)
        {
            context = _context;
        }
        public IEnumerable<TEntity> Get()
        {
            return dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return dbSet.AsNoTracking().Where(predicate).ToList();
        }
        public TEntity GetOne(Func<TEntity, bool> predicate)
        {
            return dbSet.AsNoTracking().Where(predicate).FirstOrDefault();
        }
        public TEntity FindById(int id)
        {
            return dbSet.Find(id);
        }

        public void Create(TEntity item)
        {
            dbSet.Add(item);
        }
        public void Update(TEntity item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
        public void Remove(TEntity item)
        {
            dbSet.Remove(item);
        }
        public IEnumerable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return Include(includeProperties).ToList();
        }

        public IEnumerable<TEntity> GetWithInclude(Func<TEntity, bool> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = Include(includeProperties);
            return query.AsEnumerable().Where(predicate).ToList();
        }

        private IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = dbSet.AsNoTracking();
            return includeProperties
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }
    }
}
