using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ticket_System.Models;

namespace Ticket_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext _dbContext;
        public HomeController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("user")]
        public IActionResult Index(string user)
        {
            using (_dbContext)
            {
                var user_permission_id =
                    (from u in _dbContext.user
                    join p in _dbContext.permission on u.permission_id equals p.id
                    where u.account == user
                    select p.id).ToList();

                ViewData["permission_id"] = user_permission_id[0];
                ViewData["User"] = user;
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
