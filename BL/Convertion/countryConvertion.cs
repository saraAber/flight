using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Convertion
{
    class countryConvertion
    {

        public static countryDto ConvertcountryToDto(Country country)
        {
            countryDto newcountry = new countryDto();
            newcountry.Id = country.Id;
            newcountry.Country = country.Country1;
            newcountry.CountryValue= country.CountryValue;
            return newcountry;
        }
    }
}
