using SMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.IRepository
{
    public interface IStoreRepository
    {
        Task<List<Store>> GetAllStores();
    }
}
