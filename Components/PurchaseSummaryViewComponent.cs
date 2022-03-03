using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bookstore.Models;

namespace Bookstore.Components
{
    public class PurchaseSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public PurchaseSummaryViewComponent(Basket b)
        {
            basket = b;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
