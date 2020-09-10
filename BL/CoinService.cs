using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
 public  class CoinService
    {
        public static List<CoinDto> GetAllCoins()
        {
            using (FlightsEntities db = new FlightsEntities())
            {
                return db.Coins.ToList()
                    .Select(x => Convertion.CoinConvertion.ConvertCoinToDto(x))
                    .ToList();
            }
        }
    }
}
