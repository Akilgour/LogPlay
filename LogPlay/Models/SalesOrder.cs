using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogPlay.Models
{
    public class SalesOrder
    {
        public string OrderId { get; set; }
        public List<SalesOrderItem> SalesOrderItems { get; set; }
    }
}