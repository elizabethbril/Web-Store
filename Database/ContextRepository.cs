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
        public IEnumerable<TEntity> Get()
        {
            using (ShopContext context = new ShopContext())
            {
                return context.Set<TEntity>().AsNoTracking().ToList();
            }
        }

        public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            using (ShopContext context = new ShopContext())
            {
                return context.Set<TEntity>().AsNoTracking().Where(predicate).ToList();
            }
        }
        public TEntity GetOne(Func<TEntity, bool> predicate)
        {
            using (ShopContext context = new ShopContext())
            {
                return context.Set<TEntity>().AsNoTracking().Where(predicate).FirstOrDefault();
            }
        }
        public TEntity FindById(int id)
        {
            using (ShopContext context = new ShopContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public void Create(TEntity item)
        {
            using (ShopContext context = new ShopContext())
            {
                context.Set<TEntity>().Add(item);
                context.SaveChanges();
            }
        }
        public void Update(TEntity item)
        {
            using (ShopContext context = new ShopContext())
            {
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Remove(TEntity item)
        {
            using (ShopContext context = new ShopContext())
            {
                context.Set<TEntity>().Remove(item);
                context.SaveChanges();
            }
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
            using (ShopContext context = new ShopContext())
            {
                IQueryable<TEntity> query = context.Set<TEntity>().AsNoTracking();
                return includeProperties
                    .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            }
        }
    }
}
