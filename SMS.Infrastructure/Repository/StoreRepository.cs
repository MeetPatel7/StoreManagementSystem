using Microsoft.EntityFrameworkCore;
using SMS.Domain.Entities;
using SMS.Domain.IRepository;
using SMS.Infrastructure.StoreDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Infrastructure.Repository
{
    public class StoreRepository : IStoreRepository
    {
        private readonly AppDbContext _context;
        public StoreRepository(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<List<Store>> GetAllStores()
        {
            return await _context.Stores.ToListAsync();
        }

        public async Task<Store> GetStoreById(int storeId)
        {
            return await _context.Stores.FindAsync(storeId);
        }

        public async Task AddStore(Store store)
        {
            await _context.Stores.AddAsync(store);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateStore(Store store)
        {
            _context.Stores.Update(store);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStore(int storeId)
        {
            var store = await _context.Stores.FindAsync(storeId);
            if (store != null)
            {
                _context.Stores.Remove(store);
                await _context.SaveChangesAsync();
            }
        }
    }
}
