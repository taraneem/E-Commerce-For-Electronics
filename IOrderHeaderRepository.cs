﻿using MyShop.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Entities.Repositories
{
    public  interface IOrderHeaderRepository : IGenericRepository<OrderHeader>
    {

        void Update(OrderHeader orderheader);
        void UpdateOrderStatus(int Id, string? OrderStatus, string? PaymentStatus);
        
    }
}
