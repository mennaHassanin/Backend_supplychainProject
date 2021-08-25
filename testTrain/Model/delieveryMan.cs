using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testTrain.Model
{
    [Index(nameof(delieveryMan.nationalID), IsUnique = true)]
    public class delieveryMan : IdentityUser
    {
        //public string Id { get; set; }
        public string nationalID { get; set; }
        public string phoneNumber { get; set; }
        public string fullName { get; set; }
        public string password { get; set; }
        public string carType { get; set; }
        public string plateNumbers { get; set; }
        public string plateLetters { get; set; }
        public string pickUpLocation { get; set; }
        public float capacity { get; set; }


    }
}
