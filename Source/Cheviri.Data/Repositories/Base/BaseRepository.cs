using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Npgsql;

using System.IO;
using System.Reflection;
using System.Threading;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Cheviri.Data.Entities.Base;

namespace Cheviri.Data.Repositories.Base
{
    class BaseRepository<T, R> where T : BaseEntity
                                           where R : BaseRevision<T> 
    {
        public Task<bool> Any(Expression<Func<BaseEntity, bool>> where = null)
        {
            throw new NotImplementedException();
        }

        public Task<long> Count(Expression<Func<BaseEntity, bool>> where = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id, int currentUserId)
        {
            throw new NotImplementedException();
        }

        public Task<int> Insert(BaseEntity entity, int currentUserId)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertBulk(IEnumerable<BaseEntity> entities, int currentUserId)
        {
            throw new NotImplementedException();
        }

        public Task<long> Max(Expression<Func<BaseEntity, bool>> where = null, Expression<Func<BaseEntity, int>> column = null)
        {
            throw new NotImplementedException();
        }

        public Task<long> Min(Expression<Func<BaseEntity, bool>> where = null, Expression<Func<BaseEntity, int>> column = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> Select(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<List<BaseEntity>> SelectAfter(int lastId, int take = 100, bool isAscending = true)
        {
            throw new NotImplementedException();
        }

        public Task<BaseEntity> SelectById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BaseEntity>> SelectMany(Expression<Func<BaseEntity, bool>> where = null, int skip = 0, int take = 1000, bool isAscending = true)
        {
            throw new NotImplementedException();
        }

        public Task<List<BaseRevision<BaseEntity>>> SelectRevisions(int id)
        {
            throw new NotImplementedException();
        }

        public Task<long> Sum(Expression<Func<BaseEntity, bool>> where = null, Expression<Func<BaseEntity, long>> column = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UndoDelete(int id, int currentUserId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(BaseEntity entity, int currentUserId)
        {
            throw new NotImplementedException();
        }
    }
}
