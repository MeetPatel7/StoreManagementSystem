using SMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.IRepository
{
    public interface IRoleRepository
    {
        Task<List<Role>> GetAllRoles();
        Task AddRole(Role role);
        //Task DeleteRole(int roleId);
    }
}
