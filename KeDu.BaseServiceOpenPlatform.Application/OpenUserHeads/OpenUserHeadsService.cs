using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using KeDu.BaseServiceOpenPlatform.IRepositories;
using KeDu.BaseServiceOpenPlatform.OpenUserHeads.Dtos;

namespace KeDu.BaseServiceOpenPlatform.OpenUserHeads
{
    public class OpenUserHeadsService : ApplicationService, IOpenUserHeadsService
    {
        private readonly IDapperRepository<Models.OpenUserHeads, Guid> _openUserHeadsRepository;

        public OpenUserHeadsService(IDapperRepository<Models.OpenUserHeads, Guid> openUserHeadsRepository)
        {
            _openUserHeadsRepository = openUserHeadsRepository;
        }

        public GetOpenIdOutput GetOpenId(GetOpenIdInput input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            var openUserHead =
                _openUserHeadsRepository.FirstOrDefault(
                    x =>
                        x.UserId == input.UserId &&
                        x.OpenPlatformMicroApplicationId == input.OpenPlatformMicroApplicationId);
            if (openUserHead == null)
            {
                var id = Guid.NewGuid();
                openUserHead = _openUserHeadsRepository.Insert(new Models.OpenUserHeads
                {
                    CreateTime = DateTime.Now,
                    OpenPlatformMicroApplicationId = input.OpenPlatformMicroApplicationId,
                    UserId = input.UserId,
                    Id = id,
                    OpenId = id.ToString("N")
                });
            }
            return new GetOpenIdOutput { OpenId = openUserHead.OpenId };
        }
    }
}
