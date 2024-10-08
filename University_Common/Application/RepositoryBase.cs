﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using University_Common.Domain;

namespace University_Common.Application
{
    public class RepositoryBase<TKey, TEntity> : IRepositoryBase<TKey, TEntity> where TEntity : EntityBase<TKey>
    {
        #region Constactore

        public DbContext dbSet;
        public DbSet<TEntity> db;

        public RepositoryBase(DbContext dbSet)
        {
            this.dbSet = dbSet;
            this.db = dbSet.Set<TEntity>();
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

        public async Task<IQueryable<TEntity>> GetSelectList()
        {
            return db.AsQueryable();
        }

        public IQueryable<TEntity> GetAllRemove(bool isRemove)
        {
            return db.Where(w => w.IsRemove == isRemove);
        }

        public IQueryable<TEntity> GetAllActive(bool isActive)
        {
            return db.Where(w => w.IsActive == isActive);
        }


        public async Task<TEntity> GetFirstOrDefaultAsync(string name)
        {
            return await NewMethod(name);

            async Task<TEntity> NewMethod(string name)
            {
                return await db.FirstOrDefaultAsync(predicate: e => EF.Property<string>(e, "Name") == name);
            }
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
                dbSet.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<int> SaveChangesAsync()
        {

            return await dbSet.SaveChangesAsync();

        }

        public bool Update(TEntity entity)
        {
            try
            {
                dbSet.Update(entity);
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
            return db.Where(predicate).AsQueryable();
        }

        async Task<List<SelectListItem>> IRepositoryBase<TKey, TEntity>.GetSelectList()
        {
            var entities = await db.ToListAsync();

            var selectList = entities.Select(e => new SelectListItem
            {
                Value = e.Id.ToString(), // فرض بر این است که TEntity یک خاصیت Id دارد
                Text = e.Name // فرض بر این است که TEntity یک خاصیت Name دارد
            }).ToList();

            return selectList;
        }

        #endregion
    }
}
