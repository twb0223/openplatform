using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using KeDu.BaseServiceOpenPlatform.IRepositories;
using KeDu.BaseServiceOpenPlatform.Models;

namespace KeDu.BaseServiceOpenPlatform.EntityFramework.Repositories
{
    public class MicroApplicationAuthorizationRepository : BaseServiceOpenPlatformRepositoryBase<MicroApplicationAuthorization>, IMicroApplicationAuthorizationRepository
    {
        public MicroApplicationAuthorizationRepository(IDbContextProvider<BaseServiceOpenPlatformDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
