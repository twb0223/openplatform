using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeDu.BaseServiceOpenPlatform.OpenPlatformUsers.Dtos
{
    public class OpenPlatformUsersOutput
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
