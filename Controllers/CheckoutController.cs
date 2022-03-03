using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Checkout()
        {
            return View(new Checkout());
        }
    }
}
