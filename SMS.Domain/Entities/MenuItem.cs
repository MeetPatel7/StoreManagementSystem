using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public string MenuItemName { get; set; }
        public Decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int StoreId { get; set; }
        public Store Store { get; set; }

        //public ICollection<OrderItem> OrderItems { get; set; }

    }
}
