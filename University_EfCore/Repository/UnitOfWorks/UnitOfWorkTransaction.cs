using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_EfCore.Context;

namespace University_EfCore.Repository.UnitOfWorks
{
    public class UnitOfWorkTransaction: IDisposable
    {
        private IDbContextTransaction? _transaction = null;
        private readonly ApplicationContext _context;

        public UnitOfWorkTransaction(ApplicationContext context)
        {
            _transaction = context.Database.BeginTransaction();
            _context = context;
        }

        public void Dispose()
        {
            if (null != _transaction)
                _transaction.Rollback();

            _transaction = null;
        }

        public void Commit()
        {
            if (null != _transaction)
                _transaction.Commit();

            _transaction = null;
        }

        public void Rollback()
        {
            if (null != _transaction)
            {
                _context.ChangeTracker.Clear();
                _transaction.Rollback();
            }

            _transaction = null;
        }
    }
}
