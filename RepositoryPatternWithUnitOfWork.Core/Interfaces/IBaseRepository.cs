using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUnitOfWork.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
         T GetById(int id);

        IEnumerable<T> GetAll();
        T Find(Expression<Func<T, bool>> criteria, string[] includes = null);

        IEnumerable<T> FindAll(Expression<Func<T, bool>> criteria, string[] includes = null);

        IEnumerable<T> FindAll(Expression<Func<T, bool>> criteria, int Take,int Skip);

        T Add(T entity);

    }
}
