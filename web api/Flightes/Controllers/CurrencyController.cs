using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Flightes.Controllers
{
    public class CurrencyController : ApiController
    {

        public IHttpActionResult GetUsers()
        {
          return Json(CurrencyService.getCurrcy());
           
        }
    }
}
