﻿using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Flightes.Controllers
{
    public class TypeLineController : ApiController
    {
        public List<TypeInfoDto> GetCountry()
        {
            return TypeINfoservice.Get();
        }
    }
}
