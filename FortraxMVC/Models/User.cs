using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortraxMVC.Models
{
    public class User : IdentityUser
    {
        public User()
        {            
            this.Tickets = new HashSet<Ticket>();
            this.Orders = new HashSet<Order>();            
            this.Comments = new HashSet<Comment>();            
        }      

        public string FullName { get; set; }              
       
        public ICollection<Ticket> Tickets { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Comment> Comments { get; set; }        
        
    }
}
