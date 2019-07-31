using FortraxMVC.Data;
using FortraxMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortraxMVC.Services
{
    public class LotteryService : ILotteryService
    {
        private readonly ApplicationDbContext db;

        public LotteryService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public Ticket GetWinningTicket(string id)
        {
           var allTcikets = this.db.Lottery.SelectMany(x => x.Tickets.Where(y => y.LotteryId == id)).ToList();

            return allTcikets.RandomElement();
        }
    }

    public static class CollectionExtension
    {
        private static Random rng = new Random();

        public static T RandomElement<T>(this IList<T> list)
        {
            return list[rng.Next(list.Count)];
        }

        public static T RandomElement<T>(this T[] array)
        {
            return array[rng.Next(array.Length)];
        }
    }
}
