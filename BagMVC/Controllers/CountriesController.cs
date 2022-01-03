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

    public class CountriesController : _BaseController {

        // readonly means it can only be read once. It is also faster
        private readonly ICountry countryImpl;

        /// <summary>
        /// Using dependency injection to get the coutry context.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="countryImpl"></param>
        public CountriesController(BagContext context, ICountry countryImpl) : base(context) {
            this.countryImpl = countryImpl;
        }

        // GET: Countries
        public async Task<IActionResult> Index() {
            //return View(await _context.Country.ToListAsync());

            return View(await countryImpl.GetAllCountriesCurrenciesAsync());
        }

        public async Task<IActionResult> Details(int? id) {
            if (id == null) return NotFound();

            Country country = await countryImpl.GetCountryByIdAsync((int)id);

            if (country == null) return NotFound();

            return View(country);
        }
    }
}