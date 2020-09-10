using DTO;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Ajax.Utilities;
using System.Web.UI.WebControls;

namespace Flightes.Controllers
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
