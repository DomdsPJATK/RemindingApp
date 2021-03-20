using System;

namespace WebApplication.Model
{
    public class Order
    {
        public int IdOrder { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime dueDate { get; set; }
        public string Comments { get; set; }
        public int IdClient { get; set; }
        public int IdEmployee { get; set; }

        public Client Client { get; set; }
        public Employee Employee { get; set; }
    }
}