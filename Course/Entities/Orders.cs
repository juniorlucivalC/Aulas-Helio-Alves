﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Course.Entities.Enums;


namespace Course.Entities
{
    class Orders 
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }


        public override string ToString()
        {
            return "Id:" + Id + ", " + Moment + ", " + Status;
        }

    }
}
