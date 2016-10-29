using KeDu.BaseServiceOpenPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeDu.BaseServiceOpenPlatform.IRepositories
{
    public interface IOpenPlatformUsersRepository : IDapperRepository<OpenPlatformUsers, Guid>
    {
    }
}
