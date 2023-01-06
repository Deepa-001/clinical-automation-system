using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewProjectCAS.Models
{
    public class SupplierDashboardModel
    {
        public int TotalOrders { get; set; }
        public int Requested { get; set; }
        public int Dispatched { get; set; }
        public int Delivered { get; set; }
    }
}