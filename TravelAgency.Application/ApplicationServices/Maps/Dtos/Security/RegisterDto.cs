using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using TravelAgency.Domain.Constant;

>>>>>>> master
=======
using TravelAgency.Domain.Constant;

>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79

namespace TravelAgency.Application.ApplicationServices.Maps.Dtos.Security
{
    public class RegisterDto : UserDto
    {
        public string Password { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
=======
        
        public string role{get; set;} = Role.Tourist;
>>>>>>> master
=======
        
        public string role{get; set;} = Role.Tourist;
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
    }
}