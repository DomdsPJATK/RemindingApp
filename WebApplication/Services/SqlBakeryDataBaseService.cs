using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Services
{
    public class SqlBakeryDataBaseService : IBakeryDataBaseService
    {
        public Task<IActionResult> getOrders()
        {
            throw new System.NotImplementedException();
        }
    }
}