using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortraxMVC.Models
{
    public class Comment
    {
        public Comment()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public DateTime PostedOn { get; set; }

        public double Review { get; set; }

        public string ProductId { get; set; }
        public Product Product { get; set; }

        public string AuthorId { get; set; }
        public User Author { get; set; }
    }
}
