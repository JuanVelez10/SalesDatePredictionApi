﻿using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class OrderDetail
    {
        public int Orderid { get; set; }
        public int Productid { get; set; }
        public decimal Unitprice { get; set; }
        public short Qty { get; set; }
        public decimal Discount { get; set; }

        public virtual Product Product { get; set; } = null!;
    }
}
