using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ticket_System.Models;

namespace Ticket_System.Controllers
{
    public class LoginController : Controller
    {
        private readonly MyDbContext _dbContext;
        public LoginController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }        

        public IActionResult Index()
        {
            var user = new user();
            string tMessage = TempData["Message"] as string;
            return View(user);
        }
        
        [HttpPost]
        public IActionResult Login(user user)
        {
            if (ModelState.IsValid)
            {
                using (_dbContext)
                {
                    var has = _dbContext.user.Where(x => x.account == user.account & x.password == user.password).Count();
                    user.password = "";                    

                    if (has > 0)
                    {
                        return RedirectToAction("Index", "Home", new { user = user.account });
                    }
                    else
                    {
                        TempData["Message"] = "帳號或密碼輸入錯誤";
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            return RedirectToAction(nameof(Index));
        }

    }
}