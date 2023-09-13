using AkijBashirGroup.Interface;
using AkijBashirGroup.ModelContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace AkijBashirGroup.Repo
{
        public abstract class Base<T> : IBase<T> where T : class
    {
        protected ModelDbContext ModelDbContext { get; set; }
        public Base(ModelDbContext modelDbContext)
        {
            ModelDbContext = modelDbContext;
        }
        public IQueryable<T> FindAll() => ModelDbContext.Set<T>().AsNoTracking();
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
            ModelDbContext.Set<T>().Where(expression).AsNoTracking();
        public void Create(T entity) => ModelDbContext.Set<T>().Add(entity);

        public void CreateRange(IEnumerable<T> entities) => ModelDbContext.Set<T>().AddRange(entities);
        
        public void Update(T entity) => ModelDbContext.Set<T>().Update(entity);
        public void Delete(T entity) => ModelDbContext.Set<T>().Remove(entity);
        public void DeleteRange(IEnumerable<T> entities) => ModelDbContext.Set<T>().RemoveRange(entities);

        public void SaveChanges()
        {
            ModelDbContext.SaveChanges();
        }
    }

}
