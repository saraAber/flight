using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BL
{
    public class InformationService
    {
        public static FlightInforDto Post(InformaDto inf)
        {
            using (FlightsEntities db = new FlightsEntities())
            {
                FlightInfor flightInforDto = new FlightInfor();
                List<file> files = new List<file>();
                List<Information> information = new List<Information>();
                flightInforDto = Convertion.FlightInformationConvrtion.ConvertFlightToDto(inf.FlightInforDto);
                inf.listFieles.ForEach(x =>
                {
                    flightInforDto.files.Add(Convertion.FielsConvertion.ConvertFileToDto(x));
                });
                inf.listInformation.ForEach(x =>
                {
                    flightInforDto.Information.Add(Convertion.InformatinConvertion.ConvertFlightToDto(x));
                });
                db.FlightInfors.Add(flightInforDto);
                db.SaveChanges();
                return Convertion.FlightInformationConvrtion.ConvertFlightToDto(flightInforDto);
            }
        }

    }
}
