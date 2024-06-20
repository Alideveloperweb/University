using System.Linq.Expressions;


namespace University_Common.Domain
{
    public interface IRepositoryBase<TKey, TEntity> where TEntity : class
    {
        TEntity Get(TKey Id);
        Task<TEntity> GetFirstOrDefaultAsync(string name);
        List<TEntity> GetAll();
        bool Create(TEntity entity);
        bool CreateRenge(List<TEntity> entity);
        bool Update(TEntity entity);
        bool Remove(TEntity entity);
        bool RemoveRenge(List<TEntity> entity);
        bool Exist(Expression<Func<TEntity,bool>> entity);
        bool SaveChanges();
       Task<int> SaveChangesAsync();
    }
}
