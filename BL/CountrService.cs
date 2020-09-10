using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class CountrService
    {
        public static List<countryDto> GetAllcountrys()
        {
            using (FlightsEntities db = new FlightsEntities())
            {
                return db.Countries.ToList().Select(x => Convertion.countryConvertion.ConvertcountryToDto(x)).ToList();
            }
        }
    }
}
