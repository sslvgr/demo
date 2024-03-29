﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class User : IdentityUser
    {
        public ICollection<UserFlight> UserFlights { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
