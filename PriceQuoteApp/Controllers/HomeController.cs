using Microsoft.AspNetCore.Mvc;
using PriceQuoteApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuoteApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(PriceQuoteAppModel model)
        {
            if (ModelState.IsValid)

            {
                model.DiscountAmount = model.SubTotal * model.DiscountPercent / 100;
                model.Total = model.SubTotal - model.DiscountAmount;

            }

            return View(model);
        }
    }
}

