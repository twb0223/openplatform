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
    public class MicroApplicationVisibleRangeRepository : BaseServiceOpenPlatformRepositoryBase<MicroApplicationVisibleRange>, IMicroApplicationVisibleRangeRepository
    {
        public MicroApplicationVisibleRangeRepository(IDbContextProvider<BaseServiceOpenPlatformDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
