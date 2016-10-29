using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;
using Dapper;
using KeDu.BaseServiceOpenPlatform.IRepositories;

namespace KeDu.BaseServiceOpenPlatform.EntityFramework.Repositories
{
    public abstract class BaseServiceOpenPlatformRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<BaseServiceOpenPlatformDbContext, TEntity, TPrimaryKey>, IDapperRepository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected BaseServiceOpenPlatformRepositoryBase(IDbContextProvider<BaseServiceOpenPlatformDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public IEnumerable<T> Query<T>(string sql, dynamic param = null)
        {
            return Context.Database.Connection.Query<T>(sql, (object)param);
        }
    }

    //add common methods for all repositories

    public abstract class BaseServiceOpenPlatformRepositoryBase<TEntity> : BaseServiceOpenPlatformRepositoryBase<TEntity, Guid>
        where TEntity : class, IEntity<Guid>
    {
        protected BaseServiceOpenPlatformRepositoryBase(IDbContextProvider<BaseServiceOpenPlatformDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
