using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;

namespace BagMVC.Services {

    public abstract class ApiBaseClient {
        protected readonly IConfiguration _configuration;

        protected string mUrl = "https://my-json-server.typicode.com/OscarMorton/MyStockExchange/";
        protected readonly HttpClient Client;

        public ApiBaseClient(HttpClient httpClient) {
            //_configuration = configuration;
            Client = httpClient;
            Client.BaseAddress = new Uri(mUrl);
        }
    }
}