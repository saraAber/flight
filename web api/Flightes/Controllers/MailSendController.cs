using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;

namespace Flightes.Controllers
{
    public class MailController : ApiController
    {
        public string GetCountry(string Maill, int idFlight)
        {
          return  MailSend.send(Maill,idFlight);
        }
    }
}