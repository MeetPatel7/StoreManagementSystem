using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class Store
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;

        public ICollection<User> Users { get; set; }
        //public ICollection<Category> Category { get; set; }
        //public ICollection<Order> Orders { get; set; }

    }
}
