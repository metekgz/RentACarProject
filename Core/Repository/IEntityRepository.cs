using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Repository
{
    public interface IEntityRepository<T> where T:class,IModel,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Expression<Func<T, bool>> filter);
    }
}
