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
    public class InformationController : ApiController
    {

        [HttpPost]
        public IHttpActionResult Post(InformaDto data)
        {

            if (data != null)
            {
                InformaDto informaDto = new InformaDto();
                informaDto = data;
                return Ok(InformationService.Post(informaDto));
            }
            return null;
        }
    }
}
