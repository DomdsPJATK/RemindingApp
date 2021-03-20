using System.Collections.Generic;

namespace WebApplication.Model
{
    public class OrderConfectionary
    {
        public int IdConfectionary { get; set; }
        public int IdOrder { get; set; }
        public int Quantity { get; set; }
        public string Comments { get; set; }
        
        public Order Order { get; set; }
        public Confectionery Confectionery { get; set; }
    }
}