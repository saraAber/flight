using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InformaDto
    {

        public InformaDto()
        {
            listInformation = new List<InformationDto>();
            listFieles = new List<FielesDto>();
        }
        public FlightInforDto FlightInforDto { get; set; }
        public List<InformationDto> listInformation { get; set; }
        public List<FielesDto> listFieles { get; set; }
    }
}
