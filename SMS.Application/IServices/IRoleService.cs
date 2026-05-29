using SMS.Application.DTOs;
using SMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Application.IServices
{
    public interface IRoleService
    {
        Task<List<RoleDto>> GetAllRoles();
        Task<CreateRoleDto> AddRole(CreateRoleDto createRoleDto);
        //Task DeleteRole(int roleId);
    }
}
