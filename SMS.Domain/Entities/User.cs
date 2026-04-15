using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email {  get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;

        public int StoreId { get; set; }
        public Store Store { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
