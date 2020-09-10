using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.Convertion
{
  public static  class FlightInformationConvrtion
    {
        public static FlightInforDto ConvertFlightToDto(FlightInfor flight)
        {
            FlightInforDto newflightInfor =new FlightInforDto();
            newflightInfor.BackDate = flight.BackDate;
            newflightInfor.Dates = flight.Dates;
            newflightInfor.From = flight.From;
            newflightInfor.Id = flight.Id;
            newflightInfor.IdUser = flight.IdUser;
            newflightInfor.StartDate = flight.StartDate;
            newflightInfor.ToPlice = flight.ToPlice;
            newflightInfor.TZUser = flight.TZUser;
            newflightInfor.UserName = flight.UserName;
            return newflightInfor;
        }
        public static FlightInfor ConvertFlightToDto(FlightInforDto flight)
        {
            FlightInfor newflightInfor = new FlightInfor();
            newflightInfor.BackDate = flight.BackDate;
            newflightInfor.Dates = flight.Dates;
            newflightInfor.From = flight.From;
            newflightInfor.Id = flight.Id;
            newflightInfor.IdUser = flight.IdUser;
            newflightInfor.StartDate = flight.StartDate;
            newflightInfor.ToPlice = flight.ToPlice;
            newflightInfor.TZUser = flight.TZUser;
            newflightInfor.UserName = flight.UserName;
            return newflightInfor;
        }
        public static string stringLine(FlightInforDto information)
        {
            using (FlightsEntities db = new FlightsEntities())
            {
                return "פרטי הנסיעה להלן: <br> " +
                   "הנוסע " + information.UserName + "<br>" +
                   "מספר זהות   " + information.TZUser + "<br>" +
                      "ממדינת " + db.Countries.FirstOrDefault(x => x.Id == information.From).CountryValue + "<br>" +
                   "למדינת: " + db.Countries.FirstOrDefault(x => x.Id == information.ToPlice).CountryValue + "<br>" +
                   " בין התאריכים  " + information.StartDate.ToString("dd/MM/yy")  + "-"
                   + information.BackDate.ToString("dd/MM/yy") + "<br>" +
                " סהכ ימים" + information.Dates+ "<br>";
                    
            }
        }
    }
}
