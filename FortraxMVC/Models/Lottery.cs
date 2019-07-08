using FortraxMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortraxMVC.Models
{
    public class Lottery
    {
        public Lottery()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Tickets = new HashSet<Ticket>();
        }

        public string Id { get; set; }

        public Prizes Prizes { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
