﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Dotteam.Models
{
    [Authorize]
    public class MemberViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleNormalizedName { get; set; }
    }
}
