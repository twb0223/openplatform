using Abp.EntityFramework;
using KeDu.BaseServiceOpenPlatform.IRepositories;
using KeDu.BaseServiceOpenPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeDu.BaseServiceOpenPlatform.EntityFramework.Repositories
{
    public class OpenPlatformUsersRepository: BaseServiceOpenPlatformRepositoryBase<OpenPlatformUsers>, IOpenPlatformUsersRepository
    {
        public OpenPlatformUsersRepository(IDbContextProvider<BaseServiceOpenPlatformDbContext> dbContextProvider)
            :base(dbContextProvider)
        {
        }
    }
}
