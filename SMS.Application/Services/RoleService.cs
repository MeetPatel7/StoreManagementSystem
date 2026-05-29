using SMS.Application.DTOs;
using SMS.Application.IServices;
using SMS.Domain.Entities;
using SMS.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Application.Services
{
    public class RoleService: IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<List<RoleDto>> GetAllRoles()
        {
            var roles = await _roleRepository.GetAllRoles();

            return roles.Select(r => new RoleDto
            {
                RoleId = r.RoleId,
                RoleName = r.RoleName,
                StoreId = r.StoreId
            }).ToList();
        }

        public async Task<CreateRoleDto> AddRole(CreateRoleDto createRoleDto)
        {
            var role = new Role
            {
                RoleName = createRoleDto.RoleName,
                StoreId = createRoleDto.StoreId
            };
            await _roleRepository.AddRole(role);
            
            return createRoleDto;
        }
    }
}
