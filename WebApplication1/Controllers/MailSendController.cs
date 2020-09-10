using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class MailSendController : ApiController
    {
        public string GetCountry(string to, string ccc, int idFlight)
        {
            return MailSend.send(to, ccc, idFlight);
        }
    }
}
