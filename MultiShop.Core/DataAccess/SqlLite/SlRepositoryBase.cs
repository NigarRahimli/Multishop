using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Core.DataAccess.SqlLite
{
    public class SlRepositoryBase<TEntity> : IRepositoryBase<TEntity>
    {
        public void Add(TEntity entity)
        {
            Console.WriteLine("SqlLite-a elave olundu");
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> DeleteAll(Expression<Func<TEntity, bool>>? entity = null)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? entity = null)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
