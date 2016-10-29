using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using KeDu.BaseServiceOpenPlatform.OpenPlatformMicroApplication.Dtos;

namespace KeDu.BaseServiceOpenPlatform
{
    internal static class DtoMappings
    {
        public static void Map()
        {
            //I specified mapping for AssignedPersonId since NHibernate does not fill Task.AssignedPersonId
            //If you will just use EF, then you can remove ForMember definition.
            Mapper.Initialize(config =>
            {
                config.CreateMap<Models.OpenPlatformMicroApplication, OpenPlatformMicroApplicationDto>();
            });
        }
    }
}
