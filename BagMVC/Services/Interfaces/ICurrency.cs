using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BagLib.Models;

namespace BagMVC.Services.Interfaces {

    public interface ICurrency {

        Task<List<Currency>> GetAllCurrenciesAsync();

        Task<Currency> GetCurrencyByIdAsync(int id);
    }
}