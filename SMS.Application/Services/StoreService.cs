using SMS.Application.DTOs;
using SMS.Application.IServices;
using SMS.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Application.Services
{
    public class StoreService: IStoreService
    {
        private readonly IStoreRepository _store;
        public StoreService(IStoreRepository store)
        {
            _store = store;
        }

        public async Task<List<StoreDto>> GetAllStores()
        {
            var stores = await _store.GetAllStores();

            return stores.Select(s => new StoreDto
            {
                StoreName = s.StoreName,
                Address = s.Address,
                CreateAt = s.CreateAt
            }).ToList();
        }
    }
}
