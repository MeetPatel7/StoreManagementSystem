using Azure.Identity;
using Microsoft.EntityFrameworkCore.Metadata;
using SMS.Application.DTOs;
using SMS.Application.IServices;
using SMS.Domain.Entities;
using SMS.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<UserDto>> GetAllUsers()
        {
            var users = await _userRepository.GetAllUsers();

            return users.Select(u => new UserDto
            {
                UserName = u.UserName,
                Email = u.Email,
                Password = u.Password,
                ImageUrl = u.ImageUrl,
                StoreId = u.StoreId
            }).ToList();
        }

        public async Task<UserDto> GetUserById(int userId)
        {
            var user = await _userRepository.GetUserById(userId);
            if(user == null)
                return null;

            return new UserDto
            {
                UserName = user.UserName,
                Email = user.Email,
                Password = user.Password,
                ImageUrl = user.ImageUrl,
                StoreId = user.StoreId
            };
        }

        public async Task<CreateUserDto> AddUser(CreateUserDto createUserDto)
        {
            var user = new User
            {
                UserName = createUserDto.UserName,
                Email = createUserDto.Email,
                Password = createUserDto.Password,
                ImageUrl = createUserDto.ImageUrl,
                StoreId = createUserDto.StoretId
            };

            await _userRepository.AddUser(user);

            return createUserDto;
        }
    }
}
