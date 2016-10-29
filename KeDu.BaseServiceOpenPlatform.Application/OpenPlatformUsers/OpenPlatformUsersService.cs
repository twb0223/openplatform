using KeDu.BaseServiceOpenPlatform.OpenPlatformUsers.Dtos;
using KeDu.BaseServiceOpenPlatform.IRepositories;
using AutoMapper;
using System;

namespace KeDu.BaseServiceOpenPlatform.OpenPlatformUsers
{
    public class OpenPlatformUsersService : IOpenPlatformUsersService
    {
        private readonly IOpenPlatformUsersRepository _openPlatformUsersRepository;
        public OpenPlatformUsersService(IOpenPlatformUsersRepository openPlatformUsersRepository)
        {
            _openPlatformUsersRepository = openPlatformUsersRepository;
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="input"></param>
        public bool ChangePassword(OpenPlatformUserChangePasswordInput input)
        {
            var model = _openPlatformUsersRepository.FirstOrDefault(x => x.UserName == input.UserName && x.Password == input.OldPassword);
            if (model != null)
            {
                model.Password = input.NewPassword;
                _openPlatformUsersRepository.Update(model);
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// 登陆验证
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool Login(OpenPlatformUserLoginInput input)
        {
            //判断用户名和密码是否存在。
            var nums = _openPlatformUsersRepository.Count(x => x.UserName == input.UserName && x.Password == input.Password);
            return nums == 1;
        }
        /// <summary>
        /// 注册平台账户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public OpenPlatformUsersOutput Resister(OpenPlatformUsersDto input)
        {
            var model = new Models.OpenPlatformUsers
            {
                Id = Guid.NewGuid(),
                UserName = input.UserName,
                Password = input.Password,
                Email = input.Email,
                CreateTime = input.CreateTime,
                Mobile = input.Mobile
            };
            var result = _openPlatformUsersRepository.Insert(model);
            return new OpenPlatformUsersOutput
            {
                Id = result.Id,
                UserName = result.UserName,
                Email = result.Email,
                Mobile = result.Mobile,
                CreateTime = result.CreateTime
            };
        }
    }
}
