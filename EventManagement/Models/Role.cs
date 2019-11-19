using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement.Models
{
    public class Role
    {
        [Required]
        int _roleId;
        [Required]
        string _roleName;

        public int RoleId { get => _roleId; set => _roleId = value; }
        public string RoleName { get => _roleName; set => _roleName = value; }
    }
}
