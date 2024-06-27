using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using University_Common.Domain;

namespace University_Common.Application
{
    public class RepositoryBase<TKey, TEntity> : IRepositoryBase<TKey, TEntity> where TEntity : class
    {
        #region Constactore

        public DbContext _Context;
        public DbSet<TEntity> db;

        public RepositoryBase(DbContext _Context)
        {
            this._Context = _Context;
            this.db = _Context.Set<TEntity>();
        }

        #endregion


        #region 

        public bool Create(TEntity entity)
        {
            try
            {
                db.Add(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateRenge(List<TEntity> entity)
        {
            try
            {
                db.AddRange(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Exist(Expression<Func<TEntity, bool>> entity)
        {

            return db.Any(entity);
        }

        public TEntity Get(TKey Id)
        {
            return db.Find(Id);
        }

        public List<TEntity> GetAll()
        {
            return db.ToList();
        }


        public async Task<TEntity> GetFirstOrDefaultAsync(string name)
        {

            return await db.FirstOrDefaultAsync(e => EF.Property<string>(e, "Name") == name);
        }

        public bool Remove(TEntity entity)
        {
            try
            {
                db.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool RemoveRenge(List<TEntity> entity)
        {
            try
            {
                db.RemoveRange(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool SaveChanges()
        {
            try
            {
                _Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<int> SaveChangesAsync()
        {

            return await _Context.SaveChangesAsync();

        }

        public bool Update(TEntity entity)
        {
            try
            {
                _Context.Update(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IQueryable<TEntity> AsQueryable()
        {
          return db.AsQueryable();
        }

        public IQueryable<TEntity> AsQueryable(Expression<Func<TEntity, bool>> predicate)
        {
           return  db.Where(predicate).AsQueryable();
        }












        #endregion
    }
}
