using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class allSubject
    {

        public static InformaDto selectInformaitionn(int Id)
        {
            InformaDto informaDto = new InformaDto();
            using (FlightsEntities db = new FlightsEntities())
            {
                informaDto.FlightInforDto = Convertion.FlightInformationConvrtion.ConvertFlightToDto(db.FlightInfors.FirstOrDefault(x => x.Id == Id));
                db.Information.ToList().ForEach(x =>
                {
                    if (x.IdFlight == Id)
                    {
                        informaDto.listInformation.Add(Convertion.InformatinConvertion.ConvertFlightToDto(x));
                    }
                });
                db.files.ToList().ForEach(x =>
                {
                    if (x.intInfor == Id)
                    {
                        informaDto.listFieles.Add(Convertion.FielsConvertion.ConvertFileToDto(x));
                    }
                });
            }
            return informaDto;
        }
    }
}