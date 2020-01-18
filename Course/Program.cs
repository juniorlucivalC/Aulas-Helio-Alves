using Course.Entities;
using Course.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Orders orders = new Orders()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(orders);
        }

    }
}
