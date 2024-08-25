using System.Linq.Expressions;


namespace University_Common.Domain
{
    public interface IRepositoryBase<TKey, TEntity> where TEntity : class
    {
        TEntity Get(TKey Id);
        Task<TEntity> GetFirstOrDefaultAsync(string name);
        
        // !todo this must return a list of dto like selectlistitem (dont use IQueryable)
        Task<IQueryable<TEntity>> GetSelectList();
        IQueryable<TEntity> GetAllRemove(bool isRemove);
        IQueryable<TEntity> GetAllActive(bool isActive);
        bool Create(TEntity entity);
        bool CreateRenge(List<TEntity> entity);
        bool Update(TEntity entity);
        bool Remove(TEntity entity);
        bool RemoveRenge(List<TEntity> entity);
        bool Exist(Expression<Func<TEntity, bool>> entity);
        bool SaveChanges();
        Task<int> SaveChangesAsync();



        //int SaveChanges();
        //Task<int> SaveChangesAsync();
        //int SaveChangesWithoutValidation();
        IQueryable<TEntity> AsQueryable();
        IQueryable<TEntity> AsQueryable(Expression<Func<TEntity, bool>> predicate);
        //T First();
        //T First(Expression<Func<T, bool>> predicate);
        //T FirstOrDefault();
        //T FirstOrDefault(Expression<Func<T, bool>> predicate);
        //List<T> ToList();
        //List<T> ToList(Expression<Func<T, bool>> predicate);
        //int Delete(Expression<Func<T, bool>> predicate);
        //int Update(Expression<Func<T, bool>> filterExpression, Expression<Func<T, T>> updateExpression);
        //void ChangeState(T entity, EntityState state);
        //bool Any();
        //bool Any(Expression<Func<T, bool>> predicate);
        //int Count();
        //int Count(Expression<Func<T, bool>> predicate);
        //IQueryable<T> Including(params Expression<Func<T, object>>[] includeProperties);
        //T Attach(T entity);
        //IOrderedQueryable<T> OrderBy<TKey>(Expression<Func<T, TKey>> keySelector);
        //IOrderedQueryable<T> OrderByDescending<TKey>(Expression<Func<T, TKey>> keySelector);
        //int? MaxNullableInt(Expression<Func<T, int?>> predicate);
        //int? MinNullableInt(Expression<Func<T, int?>> predicate);

        //void TryUpdateManyToMany<TRel, TKey>(IEnumerable<TRel> currentItems, IEnumerable<TRel> newItems,
        //    Func<TRel, TKey> getKey) where TRel : class;

        //DbSet<T> Entity();

        //IEnumerable<TRel> Except<TRel, TKey>(IEnumerable<TRel> items, IEnumerable<TRel> other,
        //    Func<TRel, TKey> getKeyFunc);

        //IEnumerable<TRel> Subscription<TRel, TKey>(IEnumerable<TRel> items, IEnumerable<TRel> other,
        //    Func<TRel, TKey> getKeyFunc);

        //void AddIfNotExists(T entity, Expression<Func<T, bool>>? predicate = null, bool update = false);
    }
}
