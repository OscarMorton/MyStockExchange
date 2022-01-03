using BagLib.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BagMVC.Services.Interfaces;

namespace BagMVC.Services.Impl {

    public class CurrencyImpl : ApiBaseClient, ICurrency {

        public CurrencyImpl(HttpClient httpclient) : base(httpclient) {
        }

        /// <summary>
        /// Getts all the currencies from json server
        /// </summary>
        /// <returns></returns>
        public async Task<List<Currency>> GetAllCurrenciesAsync() {
            var response = await Client.GetAsync("Currencies");
            if (response.IsSuccessStatusCode) {
                return await response.Content.ReadAsAsync<List<Currency>>();
            }
            return null;
        }

        /// <summary>
        /// Get a specific currency
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Currency> GetCurrencyByIdAsync(int id) {
            var response = await Client.GetAsync($"Currencies?CurrencyId={id}");
            Currency currency = null;

            if (response.IsSuccessStatusCode) {
                var result = await response.Content.ReadAsAsync<List<Currency>>();
                if (result.Count > 0) {
                    currency = result[0];
                }
            }
            return currency;
        }
    }
}