using Abp.Application.Services;
using KeDu.BaseServiceOpenPlatform.IRepositories;
using KeDu.BaseServiceOpenPlatform.MicroApplicationAuthorization.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeDu.BaseServiceOpenPlatform.Models;

namespace KeDu.BaseServiceOpenPlatform.MicroApplicationAuthorization
{
    public class MicroApplicationAuthorizationService : ApplicationService, IMicroApplicationAuthorizationService
    {
        private readonly IMicroApplicationAuthorizationRepository _microApplicationAuthorizationRepository;
        public MicroApplicationAuthorizationService(IMicroApplicationAuthorizationRepository microApplicationAuthorizationRepository)
        {
            _microApplicationAuthorizationRepository = microApplicationAuthorizationRepository;
        }

        public Models.MicroApplicationAuthorization AddAuthorization(MicroApplicationAuthorizationDto input)
        {
            var model = new Models.MicroApplicationAuthorization
            {
                Id = Guid.NewGuid(),
                CompanyId = input.CompanyId,
                CreateTime = DateTime.Now,
                OpenPlatformMicroApplicationId = input.OpenPlatformMicroApplicationId,
                RangeId = input.RangeId,
                RangeType = input.RangeType,
                UserId = input.UserId

            };
            return _microApplicationAuthorizationRepository.Insert(model);
        }

        public bool DeleteAuthorization(Guid Id)
        {
            _microApplicationAuthorizationRepository.Delete(Id);
            return _microApplicationAuthorizationRepository.Count(x => x.Id == Id) == 1;
        }
        public Models.MicroApplicationAuthorization UpdateAuthorization(MicroApplicationAuthorizationDto input)
        {
            var result = _microApplicationAuthorizationRepository.FirstOrDefault(x => x.Id == input.Id);
            result.CompanyId = input.CompanyId;
            result.OpenPlatformMicroApplicationId = input.OpenPlatformMicroApplicationId;
            result.RangeId = input.RangeId;
            result.RangeType = input.RangeType;
            result.UserId = input.UserId;
            return _microApplicationAuthorizationRepository.Update(result);
        }
    }
}
