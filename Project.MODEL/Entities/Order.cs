﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public  class Order:BaseEntity
    {
        public DateTime? ShippedDate { get; set; }

        public string OrderAddress { get; set; }

        public int AppUserID { get; set; }




        //Relational Properties

        public virtual AppUser AppUser { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }




    }
}
