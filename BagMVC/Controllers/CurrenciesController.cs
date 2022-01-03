using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BagLib;
using BagLib.Models;
using BagMVC.Services.Interfaces;

namespace BagMVC.Controllers {

    public class CurrenciesController : _BaseController {
        private readonly ICurrency currencyImp1;

        public CurrenciesController(BagContext context, ICurrency currencyImp1) : base(context) {
            this.currencyImp1 = currencyImp1;
        }

        // GET: Currencies
        public async Task<IActionResult> Index() {
            return View(await currencyImp1.GetAllCurrenciesAsync());
        }

        // GET: Currencies/Details/5
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var currency = currencyImp1.GetCurrencyByIdAsync((int)id);
            if (currency == null) {
                return NotFound();
            }

            return View(currency);
        }
    }
}