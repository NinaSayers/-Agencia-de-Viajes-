using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using TravelAgency.Application.ApplicationServices.IServices;
using TravelAgency.Application.ApplicationServices.Maps.Dtos.Security;
using TravelAgency.Application.Interfaces;
using TravelAgency.Domain.Constant;
using TravelAgency.Infrastructure.Identity;

namespace TravelAgency.Application.ApplicationServices.Services
{
    public class IdentityService : IIdentityService
    {
<<<<<<< HEAD
        
        private readonly ITouristService _touristService;
        private readonly IIdentityManager _identityManager;
        private readonly IMapper _mapper;
        public IdentityService(IIdentityManager identityManager, IMapper mapper, ITouristService touristService)
        {
            _touristService =touristService;
            _identityManager = identityManager;
            _mapper = mapper;
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
<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> origin/real-Nanda's-Branch
>>>>>>> 8c8298ebcb71b5da9c90eea6cc660729afc04947
        }

        public async Task<bool> CheckCredentialsAsync(LoginDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
<<<<<<< HEAD
            if (user == null)return false;
            var savedUser = await _identityManager.CheckCredentialsAsync(user.UserName!,userDto.Password);
            return savedUser;
=======
            if (user == null) return false;
            var savedUser = await _identityManager.CheckCredentialsAsync(user.UserName!, userDto.Password);
            if (savedUser) return savedUser;
            return false;
<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> origin/real-Nanda's-Branch
>>>>>>> 8c8298ebcb71b5da9c90eea6cc660729afc04947
        }

        public async Task<string> CreateUserAsync(RegisterDto userDto)
        {
<<<<<<< HEAD
           var user = _mapper.Map<User>(userDto);
           var savedUser = await _identityManager.CreateUserAsync(user, userDto.Password);
           await _identityManager.AddRoles(savedUser.Id,Role.Tourist);
           await _touristService.CreateTouristAsync(savedUser);
           
           return savedUser.Id.ToString();
        } 
=======
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
>>>>>>> origin/real-Nanda's-Branch
>>>>>>> 8c8298ebcb71b5da9c90eea6cc660729afc04947
    }
}