using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class CoinSController : ApiController
    {
       
            public List<CoinDto> GetCoins()
            {
                return CoinService.GetAllCoins();
            }
        
    }
}
