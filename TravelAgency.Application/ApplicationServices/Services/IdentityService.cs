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
        
        private readonly ITouristService _touristService;
        private readonly IIdentityManager _identityManager;
        private readonly IMapper _mapper;
        public IdentityService(IIdentityManager identityManager, IMapper mapper, ITouristService touristService)
        {
            _touristService =touristService;
            _identityManager = identityManager;
            _mapper = mapper;
        }

        public async Task<bool> CheckCredentialsAsync(LoginDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            if (user == null)return false;
            var savedUser = await _identityManager.CheckCredentialsAsync(user.UserName!,userDto.Password);
            return savedUser;
        }

        public async Task<string> CreateUserAsync(RegisterDto userDto)
        {
           var user = _mapper.Map<User>(userDto);
           var savedUser = await _identityManager.CreateUserAsync(user, userDto.Password);
           await _identityManager.AddRoles(savedUser.Id,Role.Tourist);
           await _touristService.CreateTouristAsync(savedUser);
           
           return savedUser.Id.ToString();
        } 
    }
}