﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using KeDu.BaseServiceOpenPlatform.Models;

namespace KeDu.BaseServiceOpenPlatform.IRepositories
{
    public interface IMicroApplicationVisibleRangeRepository : IDapperRepository<MicroApplicationVisibleRange, Guid>
    {

    }
}
