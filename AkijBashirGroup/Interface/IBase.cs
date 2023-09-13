using System.Linq.Expressions;

namespace AkijBashirGroup.Interface
{
   
    public interface IBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void CreateRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(T entity);        
        void DeleteRange(IEnumerable<T> entities);
        void SaveChanges();
    }
}
