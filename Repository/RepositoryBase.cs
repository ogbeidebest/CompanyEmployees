using Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext;
        public RepositoryBase(RepositoryContext repositoryContext)
            => RepositoryContext = repositoryContext;
       
     /// <summary>
     /// Get all from database and return a querable
     /// </summary>
     /// <param name="trackChanges"></param>
     /// <returns>Querable list data</returns>
        public  IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
            RepositoryContext.Set<T>()
            .AsNoTracking():
            RepositoryContext.Set<T>();


        /// <summary>
        /// get a particular item
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="trackChanges"></param>
        /// <returns>a querable of the item</returns>
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
            bool trackChanges) =>
            !trackChanges ?
            RepositoryContext.Set<T>()
            .Where(expression)
            .AsNoTracking() :
            RepositoryContext.Set<T>()
            .Where(expression);

        /// <summary>
        /// Creates entity
        /// </summary>
        /// <param name="entity"></param>
        public void Create(T entity) =>RepositoryContext.Set<T>().Add(entity);

        /// <summary>
        /// update entity
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity) => RepositoryContext.Set<T>().Update(entity);

        /// <summary>
        /// delete entity
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);
    }
}
