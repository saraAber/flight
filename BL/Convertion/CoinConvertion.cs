using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Convertion
{
    class CoinConvertion
    {
        public static CoinDto ConvertCoinToDto(Coin coin)
        {
            CoinDto newCoin = new CoinDto();
            newCoin.Id = coin.Id;
            newCoin.Name = coin.Name;
            newCoin.nameValue = coin.nameValue;
            return newCoin;
        }
    }
}
