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
        Task<StoreDto> GetStoreById(int storeId);
        Task<CreateStoreDto> AddStore(CreateStoreDto createStoreDto);
        Task<UpdateStoreDto> UpdateStore(UpdateStoreDto updateStoreDto);
        Task DeleteStore(int storeId);
    }
}
