using AutoMapper;
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
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _store;
        private readonly IMapper _mapper;
        public StoreService(IStoreRepository store, IMapper mapper)
        {
            _store = store;
            _mapper = mapper;
        }

        public async Task<List<StoreDto>> GetAllStores()
        {
            var stores = await _store.GetAllStores();

            return _mapper.Map<List<StoreDto>>(stores);
            //return stores.Select(s => new StoreDto
            //{
            //    StoreName = s.StoreName,
            //    Address = s.Address,
            //    CreateAt = s.CreateAt
            //}).ToList();
        }

        public async Task<StoreDto> GetStoreById(int storeId)
        {
            var store = await _store.GetStoreById(storeId);
            if (store == null)
            {
                return null;
            }

            return _mapper.Map<StoreDto>(store);
            //return new StoreDto
            //{
            //    StoreName = store.StoreName,
            //    Address = store.Address,
            //    CreateAt = store.CreateAt
            //};
        }

        public async Task<CreateStoreDto> AddStore(CreateStoreDto createStoreDto)
        {
            var store = _mapper.Map<Store>(createStoreDto);
            //var store = new Store
            //{
            //    StoreName = createStoreDto.StoreName,
            //    Address = createStoreDto.Address
            //};

            await _store.AddStore(store);

            return _mapper.Map<CreateStoreDto>(store);
            //return createStoreDto;
        }

        public async Task<UpdateStoreDto> UpdateStore(UpdateStoreDto updateStoreDto)
        {
            var store = _mapper.Map<Store>(updateStoreDto);
            //var store = new Store
            //{
            //    StoreId = updateStoreDto.StoreId,
            //    StoreName = updateStoreDto.StoreName,
            //    Address = updateStoreDto.Address
            //};

            await _store.UpdateStore(store);

            return _mapper.Map<UpdateStoreDto>(store);
        }

        public async Task DeleteStore(int storeId)
        {
            await _store.DeleteStore(storeId);
        }
    }
}
