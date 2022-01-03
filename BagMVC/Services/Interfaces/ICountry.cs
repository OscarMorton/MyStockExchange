using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BagLib.Models;

namespace BagMVC.Services.Interfaces {

    public interface ICountry {

        Task<List<Country>> GetAllCountriesAsync();

        Task<List<Country>> GetAllCountriesCurrenciesAsync();

        Task<Country> GetCountryByIdAsync(int id);
    }
}