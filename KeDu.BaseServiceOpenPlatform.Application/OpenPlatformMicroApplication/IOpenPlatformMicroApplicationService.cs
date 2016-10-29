using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using KeDu.BaseServiceOpenPlatform.OpenPlatformMicroApplication.Dtos;

namespace KeDu.BaseServiceOpenPlatform.OpenPlatformMicroApplication
{
    /// <summary>
    /// 微应用服务
    /// </summary>
    public interface IOpenPlatformMicroApplicationService : IApplicationService
    {

        /// <summary>
        /// 获取微应用列表
        /// </summary>
        /// <param name="input">输入参数</param>
        /// <returns></returns>
        GetOpenPlatformMicroApplicationOutput GetOpenPlatformMicroApplications(
            GetOpenPlatformMicroApplicationInput input);

        /// <summary>
        /// 开发者获取自己的应用列表
        /// </summary>
        /// <param name="CreatorID">创建人ID</param>
        /// <returns></returns>
        GetOpenPlatformMicroApplicationOutput GetOpenPlatfromMicroApplicationByCreator(Guid CreatorID);

        /// <summary>
        /// 管理员获取自己审核的app列表
        /// </summary>
        /// <param name="ExamineUserID"></param>
        /// <returns></returns>
        GetOpenPlatformMicroApplicationOutput GetOpenPlatfromMicroApplicationByAdmin(Guid ExamineUserID);

        /// <summary>
        /// 用户获取自己可见的app列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        GetOpenPlatformMicroApplicationOutput GetOpenPlatfromMicroApplicationByCondition(GetOpenPlatformMicroApplicationByConditionInput input);

        /// <summary>
        /// 验证微应用
        /// </summary>
        /// <param name="input">输入参数</param>
        /// <returns></returns>
        ValidateOpenPlatformMicroApplicationOutput ValidateOpenPlatformMicroApplication(
            ValidateOpenPlatformMicroApplicationInput input);

        /// <summary>
        /// 创建新的app
        /// </summary>
        /// <param name="input">输入参数</param>
        /// <returns></returns>
        OpenPlatformMicroApplicationDto CreateNewApp(OpenPlatformMicroApplicationDto input);

        /// <summary>
        /// 更新App
        /// </summary>
        /// <param name="input">输入参数</param>
        /// <returns></returns>
        OpenPlatformMicroApplicationDto UpdateNewApp(UpdateOpenPlatformMicroApplicationInput input);
          
        /// <summary>
        /// 删除应用
        /// </summary>
        /// <param name="Id"></param>
        void DeleteApp(Guid Id);

        /// <summary>
        /// 获取应用信息
        /// </summary>
        /// <param name="appid"></param>
        /// <returns></returns>
        GetAppInfoOutput GetAppInfo(string appid);

        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        bool ExamineApp(ExamineAppInput input);


    }
}
