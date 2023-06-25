using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
        where TEntity : class
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        /*The "Entry(entity)" method is called on the context object to obtain an EntityEntry<TEntity> instance for the provided entity.
         * The EntityEntry<TEntity> provides access to various operations and metadata for the entity.
The "addEntity.State = EntityState.Added" line sets the state of the entity entry to "Added".
        This informs the context that the entity should be added to the data source when the "SaveChanges" method is called.*/

        public void Delete(TEntity entity)
        {
           using TContext context = new();  
            var removeEntity=context.Entry(entity);
            removeEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

  

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
         using TContext context = new();
            var findEntity = context.Set<TEntity>().SingleOrDefault(filter);
            //This method returns a DbSet<TEntity> instance that represents
            //a collection of entities of type TEntity in the data source.
            return findEntity;

        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            using TContext context = new();
            return filter == null 
                ? context.Set<TEntity>().ToList()
        //If the "filter" is null, it means no filtering condition is specified.
        //In this case, the method retrieves all entities of type TEntity from the data source 
                : context.Set<TEntity>().Where(filter).ToList();
        //If the "filter" is not null, it means a filtering condition is specified.
        //In this case, the method retrieves entities from the data source that satisfy the specified filter condition
        }

        public void Update(TEntity entity)
        {
            using TContext context = new();
            var updateEntity = context.Entry(entity);
            updateEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
