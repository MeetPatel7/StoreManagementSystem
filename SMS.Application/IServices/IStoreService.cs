using SMS.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Application.IServices
{
    public interface IStoreService
    {
        Task<List<StoreDto>> GetAllStores();
    }
}
