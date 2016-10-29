using Abp.Application.Services;
using KeDu.BaseServiceOpenPlatform.OpenPlatformUsers.Dtos;

namespace KeDu.BaseServiceOpenPlatform.OpenPlatformUsers
{
    public interface IOpenPlatformUsersService : IApplicationService
    {
        /// <summary>
        /// 平台用户注册
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        OpenPlatformUsersOutput Resister(OpenPlatformUsersDto input);

        /// <summary>
        /// 平台用户登陆验证
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        bool Login(OpenPlatformUserLoginInput input);

        /// <summary>
        /// 修改密码·
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        bool ChangePassword(OpenPlatformUserChangePasswordInput input);
    }
}
