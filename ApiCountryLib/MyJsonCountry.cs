using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCountryLib {

    public class MyJsonCountry {

        public MyJsonCountry() {
            Currencies = new HashSet<Currency>();
        }

        public int CountryId { get; set; }

        public string Name { get; set; }

        public string ApiName { get; set; }

        //public CurrencyType CurrencyType { get; set; }

        public ICollection<Currency> Currencies { get; set; }
    }
}