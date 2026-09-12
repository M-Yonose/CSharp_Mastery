using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Enums
{
    public class Member
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public MembershipStatus Status { get; set; }
    }
}
