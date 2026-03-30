using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public int StoreId { get; set; }
        public Store Store { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; }

    }
}
