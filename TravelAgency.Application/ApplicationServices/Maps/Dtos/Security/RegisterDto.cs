using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using TravelAgency.Domain.Constant;

>>>>>>> origin/real-Nanda's-Branch

namespace TravelAgency.Application.ApplicationServices.Maps.Dtos.Security
{
    public class RegisterDto : UserDto
    {
        public string Password { get; set; }
<<<<<<< HEAD
=======
        
        public string role{get; set;} = Role.Tourist;
>>>>>>> origin/real-Nanda's-Branch
    }
}