using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using KeDu.BaseServiceOpenPlatform.IRepositories;
using KeDu.BaseServiceOpenPlatform.OpenPlatformMicroApplication.Dtos;

namespace KeDu.BaseServiceOpenPlatform.OpenPlatformMicroApplication
{
    public class OpenPlatformMicroApplicationService : ApplicationService, IOpenPlatformMicroApplicationService
    {
        private readonly IOpenPlatformMicroApplicationRepository _openPlatformMicroApplicationRepository;
        private readonly IMicroApplicationAuthorizationRepository _microApplicationAuthorizationRepository;
        private readonly IMicroApplicationVisibleRangeRepository _microApplicationVisibleRangeRepository;
        public OpenPlatformMicroApplicationService(
            IOpenPlatformMicroApplicationRepository openPlatformMicroApplicationRepository,
           IMicroApplicationAuthorizationRepository microApplicationAuthorizationRepository,
           IMicroApplicationVisibleRangeRepository microApplicationVisibleRangeRepository)
        {
            _openPlatformMicroApplicationRepository = openPlatformMicroApplicationRepository;
            _microApplicationAuthorizationRepository = microApplicationAuthorizationRepository;
            _microApplicationVisibleRangeRepository = microApplicationVisibleRangeRepository;
        }

        public GetOpenPlatformMicroApplicationOutput GetOpenPlatformMicroApplications(GetOpenPlatformMicroApplicationInput input)
        {
            var openPlatformMicroApplications = _openPlatformMicroApplicationRepository.Query<Models.OpenPlatformMicroApplication>("SELECT * FROM dbo.OpenPlatformMicroApplication");
            return new GetOpenPlatformMicroApplicationOutput
            {
                OpenPlatformMicroApplications =
                    Mapper.Map<List<OpenPlatformMicroApplicationDto>>(openPlatformMicroApplications)
            };
        }

        public GetOpenPlatformMicroApplicationOutput GetOpenPlatfromMicroApplicationByAdmin(Guid ExamineUserID)
        {
            var openPlatformMicroApplications = _openPlatformMicroApplicationRepository.GetAllList(x => x.ExamineUserId == ExamineUserID);
            return new GetOpenPlatformMicroApplicationOutput
            {
                OpenPlatformMicroApplications =
                    Mapper.Map<List<OpenPlatformMicroApplicationDto>>(openPlatformMicroApplications)
            };
        }

        public GetOpenPlatformMicroApplicationOutput GetOpenPlatfromMicroApplicationByCreator(Guid CreatorID)
        {
            var openPlatformMicroApplications = _openPlatformMicroApplicationRepository.GetAllList(x => x.CreatorId == CreatorID);
            return new GetOpenPlatformMicroApplicationOutput
            {
                OpenPlatformMicroApplications =
                    Mapper.Map<List<OpenPlatformMicroApplicationDto>>(openPlatformMicroApplications)
            };
        }

        public GetOpenPlatformMicroApplicationOutput GetOpenPlatfromMicroApplicationByCondition(GetOpenPlatformMicroApplicationByConditionInput input)
        {
            var resultByCompany_idlist = _microApplicationAuthorizationRepository.GetAllList(x => x.RangeId == input.CompanyID && x.RangeType == 0).Select(x => x.OpenPlatformMicroApplicationId).ToList();
            var resultByShop_idlist = _microApplicationAuthorizationRepository.GetAllList(x => x.RangeId == input.ShopID && x.RangeType == 1).Select(x => x.OpenPlatformMicroApplicationId).ToList();
            var resultByDep_idlist = _microApplicationAuthorizationRepository.GetAllList(x => x.RangeId == input.DepartmentID && x.RangeType == 2).Select(x => x.OpenPlatformMicroApplicationId).ToList();
            var resultByUser_idlist = _microApplicationAuthorizationRepository.GetAllList(x => x.RangeId == input.UserID && x.RangeType == 3).Select(x => x.OpenPlatformMicroApplicationId).ToList();

            //取并集
            var openPlatformMicroApplicationsids = resultByCompany_idlist.Union(resultByShop_idlist).Union(resultByDep_idlist).Union(resultByUser_idlist).ToList();

            var openPlatformMicroApplications = _openPlatformMicroApplicationRepository.GetAllList(x => openPlatformMicroApplicationsids.Contains(x.Id));

            return new GetOpenPlatformMicroApplicationOutput
            {
                OpenPlatformMicroApplications =
                    Mapper.Map<List<OpenPlatformMicroApplicationDto>>(openPlatformMicroApplications)
            };
        }

        public ValidateOpenPlatformMicroApplicationOutput ValidateOpenPlatformMicroApplication(
            ValidateOpenPlatformMicroApplicationInput input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }
            var openPlatformMicroApplication =
                _openPlatformMicroApplicationRepository.FirstOrDefault(
                    x => x.AppId == input.AppId && x.AppSecret == input.AppSecret);

            return new ValidateOpenPlatformMicroApplicationOutput
            {
                IsValidate = openPlatformMicroApplication != null,
                OpenPlatformMicroApplication = Mapper.Map<OpenPlatformMicroApplicationDto>(openPlatformMicroApplication)
            };
        }

        public OpenPlatformMicroApplicationDto CreateNewApp(OpenPlatformMicroApplicationDto input)
        {
            var model = new Models.OpenPlatformMicroApplication
            {
                Id = input.Id,
                Name = input.Name,
                logo = input.logo,
                Introduction = input.Introduction,
                AppUrl = input.AppUrl,
                BackUrl = input.BackUrl,
                AppSecret = input.AppSecret,
                AppId = input.AppId,
                IsOpen = input.IsOpen,
                IsExamine = input.IsExamine,
                CreateTime = input.CreateTime,
                CreatorId = input.CreatorId,
                ExamineTime = input.ExamineTime,
                ExamineUserId = input.ExamineUserId
            };
            var result = _openPlatformMicroApplicationRepository.Insert(model);
            return Mapper.Map<OpenPlatformMicroApplicationDto>(result);

        }

        public OpenPlatformMicroApplicationDto UpdateNewApp(UpdateOpenPlatformMicroApplicationInput input)
        {
            var oldmodel = _openPlatformMicroApplicationRepository.Single(x => x.Id == input.Id);
            //赋值新数据
            oldmodel.logo = input.logo;
            oldmodel.Name = input.Name;
            oldmodel.Introduction = input.Introduction;
            oldmodel.AppUrl = input.AppUrl;
            oldmodel.BackUrl = input.BackUrl;

            var result = _openPlatformMicroApplicationRepository.Update(oldmodel);
            return Mapper.Map<OpenPlatformMicroApplicationDto>(result);
        }

        public void DeleteApp(Guid Id)
        {
            _openPlatformMicroApplicationRepository.Delete(Id);
        }

        public GetAppInfoOutput GetAppInfo(string AppId)
        {
            var model = _openPlatformMicroApplicationRepository.FirstOrDefault(x => x.AppId == AppId);
            if (model != null)
            {
                var result = new GetAppInfoOutput
                {
                    Id = model.Id,
                    Name = model.Name,
                    logo = model.logo,
                    AppId = model.AppId,
                    AppUrl = model.AppUrl,
                    AppSecret = model.AppSecret,
                    Introduction = model.Introduction,
                    BackUrl = model.BackUrl,
                    CreateTime = model.CreateTime,
                    CreatorId = model.CreatorId,
                    CreatorName = model.OpenPlatformUsers.UserName,
                    ExamineTime = model.ExamineTime,
                    ExamineUserId = model.ExamineUserId,
                    ExamineUserName = model.AdminUsers.UserName,
                    IsOpen = model.IsOpen,
                    IsExamine = model.IsExamine
                };
                return result;
            }
            else
            {
                return null;
            }

        }

        public bool ExamineApp(ExamineAppInput input)
        {
            var model = _openPlatformMicroApplicationRepository.FirstOrDefault(x => x.AppId == input.AppId);
            model.IsExamine = input.IsExamine;
            model.ExamineUserId = input.ExamineUserId;
            model.ExamineTime = input.ExamineTime;
            var result = _openPlatformMicroApplicationRepository.Update(model);
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
