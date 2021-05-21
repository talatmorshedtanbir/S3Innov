using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BuildingDataProject.Data
{
    public interface IRepository<TEntity, TKey, TContext>
           where TEntity : class, IEntity<TKey>
           where TContext : DbContext
    {
        void Add(TEntity entity);
        void Remove(TKey id);
        void Remove(TEntity entityToDelete);
        void Remove(Expression<Func<TEntity, bool>> filter);
        void Edit(TEntity entityToUpdate);
        int GetCount(Expression<Func<TEntity, bool>> filter = null);
        IList<TEntity> Get(Expression<Func<TEntity, bool>> filter);
        IList<TEntity> GetAll();
        TEntity GetById(TKey id);
        (IList<TEntity> data, int total, int totalDisplay) Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

        IList<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "", bool isTrackingOff = false);

        Task<IList<TResult>> GetAsync<TResult>(Expression<Func<TEntity, TResult>> selector,
                           Expression<Func<TEntity, bool>> predicate = null,
                           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                           Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
                           bool disableTracking = true);
        Task<TResult> GetFirstOrDefaultAsync<TResult>(Expression<Func<TEntity, TResult>> selector,
                    Expression<Func<TEntity, bool>> predicate = null,
                    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
                    bool disableTracking = true);
        Task AddRangeAsync(IList<TEntity> entities);
        Task UpdateAsync(TEntity entity);
    }
}
