using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Services
{
    public interface IBakeryDataBaseService
    {
        public Task<IActionResult> getOrders();
    }
}