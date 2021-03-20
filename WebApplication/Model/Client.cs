using System.Collections.Generic;

namespace WebApplication.Model
{
    public class Client
    {
        public int IdClient { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        
        public ICollection<Order> Orders { get; set; }
    }
}