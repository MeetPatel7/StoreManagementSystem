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

    }
}
