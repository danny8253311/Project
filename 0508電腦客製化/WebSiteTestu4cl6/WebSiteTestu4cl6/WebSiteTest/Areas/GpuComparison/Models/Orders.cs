﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebSiteTest.Areas.GpuComparison.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? OrderOnDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public string OrderStatus { get; set; }
        public string ShipAddress { get; set; }
        public string ShippingMethod { get; set; }
        public string AcceptEmail { get; set; }
        public string AcceptName { get; set; }
        public string AcceptNumber { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}