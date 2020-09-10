using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.Convertion
{
    public static class InformatinConvertion
    {
        public static InformationDto ConvertFlightToDto(Information information)
        {
            using (FlightsEntities db = new FlightsEntities())
            {
                InformationDto newinformation = new InformationDto();
                newinformation.Coin = db.Coins.FirstOrDefault(x => x.Id == information.Coin).Name;
                newinformation.Cost = information.Cost;
                newinformation.Id = information.Id;
                newinformation.IdFlight = information.IdFlight;
                newinformation.IdType = information.IdType;
                newinformation.countryId = information.countryId;
                newinformation.Date = information.Date;
                newinformation.Length = information.Length;
                newinformation.Pya = information.Pya;
                newinformation.WhoPay = information.WhoPay;
                return newinformation;
            }
        }
        public static Information ConvertFlightToDto(InformationDto information)
        {
            using (FlightsEntities db = new FlightsEntities())
            {
                Information newinformation = new Information();
                newinformation.Coin = db.Coins.FirstOrDefault(x => x.Name == information.Coin).Id;
                newinformation.Cost = information.Cost;
                newinformation.Id = information.Id;
                newinformation.IdFlight = information.IdFlight;
                newinformation.IdType = information.IdType;
                newinformation.countryId = information.countryId;
                newinformation.Date = information.Date;
                newinformation.Length = information.Length;
                newinformation.Pya = information.Pya;
                newinformation.WhoPay = information.WhoPay;
                                return newinformation;
            }
        }
        public static string stringLineHeader()
        {
            return "<div class='firstLine line'><p> סוג שורה: </p> <p> שילם:" +
                "</p> <p>מדינה:</p> " +
                "<p>מספר ימים</p> <p> עלות: </p>" +
                "<p>סוג מטבע</p>" +
                "<p>סהכ לתשלום</p></div><br>"
                ;
        }
        public static string stringLine(InformationDto information)
        {
            using (FlightsEntities db = new FlightsEntities())
            {
                return "<div class='line'><p>" + db.TypeInfoes.FirstOrDefault(x => x.Id == information.IdType).Type +
                    "</p><p>" + information.WhoPay + 
                    "</p><p>" + db.Countries.FirstOrDefault(x => x.Id == information.countryId).CountryValue +
                " </p><p>" + information.Length +
                " </p><p>" + information.Cost +
                " </p><p> " + db.Coins.FirstOrDefault(x => x.Name == information.Coin).nameValue +
                "</p><p>" + information.Pya + "</p></div><br>";
            }
        }

    }
}
