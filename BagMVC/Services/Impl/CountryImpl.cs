using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BagLib.Models;
using BagMVC.Services.Interfaces;

namespace BagMVC.Services.Impl {

    public class CountryImpl : ApiBaseClient, ICountry {

        public CountryImpl(HttpClient httpClient) : base(httpClient) {
        }

        public async Task<List<Country>> GetAllCountriesAsync() {
            var response = await Client.GetAsync("Countries");
            if (response.IsSuccessStatusCode) {
                return await response.Content.ReadAsAsync<List<Country>>();
            }
            return null;
        }

        public async Task<List<Country>> GetAllCountriesCurrenciesAsync() {
            var response = await Client.GetAsync("CountryCurrency");
            if (response.IsSuccessStatusCode) {
                return await response.Content.ReadAsAsync<List<Country>>();
            }
            return null;
        }

        /// <summary>
        /// Getting the spesific country
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Country> GetCountryByIdAsync(int id) {
            var response = await Client.GetAsync($"Countries?CountryId={id}");
            Country country = null;

            if (response.IsSuccessStatusCode) {
                var result = await response.Content.ReadAsAsync<List<Country>>();
                if (result.Count > 0) {
                    country = result[0];
                }
            }
            return country;
        }
    }
}