using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Application.ApplicationServices.Maps.Dtos.Security
{
    public class RegisterDto : UserDto
    {
        public string Password { get; set; }
    }
}