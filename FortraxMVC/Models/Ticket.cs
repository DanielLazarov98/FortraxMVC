using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortraxMVC.Models
{
    public class Ticket
    {
        public Ticket()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public Lottery Lottery { get; set; }
        public string LotteryId { get; set; }
    }
}
