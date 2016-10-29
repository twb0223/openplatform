using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;

namespace KeDu.BaseServiceOpenPlatform.IRepositories
{
    public interface IDapperRepository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        IEnumerable<T> Query<T>(string sql, dynamic param = null);
    }
}
