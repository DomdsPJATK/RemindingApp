using System.Collections.Generic;

namespace WebApplication.Model
{
    public class Employee
    {
        public int IdEmployee { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}