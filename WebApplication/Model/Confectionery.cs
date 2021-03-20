using System.Collections.Generic;

namespace WebApplication.Model
{
    public class Confectionery
    {
        public int IdConfectionary { get; set; }
        public string Name { get; set; }
        public float PricePerPiece { get; set; }
        public string Type { get; set; }

        public ICollection<OrderConfectionary> OrderConfectionaries { get; set; }
    }
}