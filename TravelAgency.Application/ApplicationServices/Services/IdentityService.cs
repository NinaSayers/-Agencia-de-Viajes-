using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using TravelAgency.Application.ApplicationServices.IServices;
using TravelAgency.Application.ApplicationServices.Maps.Dtos.Security;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using TravelAgency.Application.Interfaces;
using TravelAgency.Domain.Constant;
>>>>>>> master
=======
using TravelAgency.Application.Interfaces;
using TravelAgency.Domain.Constant;
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
using TravelAgency.Infrastructure.Identity;

namespace TravelAgency.Application.ApplicationServices.Services
{
    public class IdentityService : IIdentityService
    {
<<<<<<< HEAD
<<<<<<< HEAD
=======

        private readonly ITouristService _touristService;
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
        private readonly IIdentityManager _identityManager;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IMapper _mapper;
        public IdentityService(IJwtTokenGenerator jwtTokenGenerator, IIdentityManager identityManager, IMapper mapper, ITouristService touristService)
        {
            _touristService = touristService;
            _identityManager = identityManager;
            _mapper = mapper;
<<<<<<< HEAD
=======

        private readonly ITouristService _touristService;
        private readonly IIdentityManager _identityManager;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IMapper _mapper;
        public IdentityService(IJwtTokenGenerator jwtTokenGenerator, IIdentityManager identityManager, IMapper mapper, ITouristService touristService)
        {
            _touristService = touristService;
            _identityManager = identityManager;
            _mapper = mapper;
            _jwtTokenGenerator = jwtTokenGenerator;
>>>>>>> master
=======
            _jwtTokenGenerator = jwtTokenGenerator;
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
        }

        public async Task<bool> CheckCredentialsAsync(LoginDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
<<<<<<< HEAD
<<<<<<< HEAD
            if (user == null)return false;
            var savedUser = await _identityManager.CheckCredentialsAsync(user.UserName!,userDto.Password);
            return savedUser;
=======
=======
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
            if (user == null) return false;
            var savedUser = await _identityManager.CheckCredentialsAsync(user.UserName!, userDto.Password);
            if (savedUser) return savedUser;
            return false;
<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
        }

        public async Task<string> CreateUserAsync(RegisterDto userDto)
        {
<<<<<<< HEAD
<<<<<<< HEAD
           var user = _mapper.Map<User>(userDto);
           var savedUser = await _identityManager.CreateUserAsync(user, userDto.Password);
           
           return savedUser.Id.ToString();
        } 
=======
=======
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
            //!I have to return more things.
            var user = _mapper.Map<User>(userDto);
            var savedUser = await _identityManager.CreateUserAsync(user, userDto.Password);
            await _identityManager.AddRoles(savedUser.Id, userDto.role);
            await _touristService.CreateTouristAsync(savedUser);
            var token = _jwtTokenGenerator.GenerateToken(savedUser);


           return token;
        }
<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
    }
}