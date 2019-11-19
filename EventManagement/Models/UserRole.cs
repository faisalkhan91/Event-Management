using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement.Models
{
    public class UserRole
    {
        int _usr;

        public int Usr { get => _usr; set => _usr = value; }
        public List<Role> RoleList { get; set; }
    }
}
