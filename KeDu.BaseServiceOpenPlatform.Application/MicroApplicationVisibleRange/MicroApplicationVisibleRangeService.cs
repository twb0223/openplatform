using Abp.Application.Services;
using KeDu.BaseServiceOpenPlatform.MicroApplicationAuthorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeDu.BaseServiceOpenPlatform.MicroApplicationAuthorization.Dtos;
using KeDu.BaseServiceOpenPlatform.Models;
using KeDu.BaseServiceOpenPlatform.IRepositories;
using KeDu.BaseServiceOpenPlatform.MicroApplicationVisibleRange.Dtos;

namespace KeDu.BaseServiceOpenPlatform.MicroApplicationVisibleRange
{
    public class MicroApplicationVisibleRangeService : ApplicationService, IMicroApplicationVisibleRangeService
    {
        private readonly IMicroApplicationVisibleRangeRepository _microApplicationVisibleRangeRepository;
        public MicroApplicationVisibleRangeService(IMicroApplicationVisibleRangeRepository microApplicationVisibleRangeRepository)
        {
            _microApplicationVisibleRangeRepository = microApplicationVisibleRangeRepository;
        }

        public Models.MicroApplicationVisibleRange AddMicroApplicationVisibleRange(MicroApplicationVisibleRangeDto input)
        {
            var model = new Models.MicroApplicationVisibleRange
            {
                Id = Guid.NewGuid(),
                Company_Id = input.Company_Id,
                AdminUserId = input.AdminUserId,
                CreateTime = DateTime.Now,
                OpenPlatformMicroApplication_Id = input.OpenPlatformMicroApplication_Id
            };
            return _microApplicationVisibleRangeRepository.Insert(model);
        }

        public bool DeleteUpdateMicroApplicationVisibleRange(Guid Id)
        {
            _microApplicationVisibleRangeRepository.Delete(Id);
            return _microApplicationVisibleRangeRepository.Count(x => x.Id == Id) == 1;
        }

        public Models.MicroApplicationVisibleRange UpdateMicroApplicationVisibleRange(MicroApplicationVisibleRangeDto input)
        {
            var result = _microApplicationVisibleRangeRepository.FirstOrDefault(x => x.Id == input.Id);
            result.Company_Id = input.Company_Id;
            result.OpenPlatformMicroApplication_Id = input.OpenPlatformMicroApplication_Id;
            result.AdminUserId = input.AdminUserId;
            return _microApplicationVisibleRangeRepository.Update(result);
        }
    }
}
