using System;
using System.Collections.Generic;

namespace KoiOderingSystemsRepositories.Entities;

public partial class Order
{
    
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> Items { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal GrandTotal { get; set; }
    

}
