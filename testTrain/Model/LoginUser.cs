using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testTrain.Model
{
    public class LoginUser : IdentityUser
    {
        public string phoneNumber { get; set; }

        public string password { get; set; }
    }
}
