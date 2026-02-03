using System.Linq.Expressions;

namespace Application.Services.Repositories;

public interface IRepository<TEntity, TId> where TEntity : class
{
    TEntity? Get(Expression<Func<TEntity, bool>> predicate);
    IList<TEntity> GetList(Expression<Func<TEntity, bool>>? predicate = null);
    TEntity Add(TEntity entity);
    TEntity Update(TEntity entity);
    TEntity Delete(TEntity entity);
}

