using BL.Convertion;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class fileStream
    {
        private string path;
        private StreamWriter StreamWriter;
        private FileStream FileStream;
        private FileStream fileread;
        public fileStream()
        {
            path = "D:/files";
            Directory.CreateDirectory(path);
            //path = Directory.GetCurrentDirectory()+"/files";
            //Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/files");
        }

        private void newFile(string userName)
        {
            path += "/" + userName;
            Directory.CreateDirectory(path);
            path += "/" + userName + "" + DateTime.Today.ToString("dd_MM_yy_mm_hh") + ".html";
            FileStream = new FileStream(path , FileMode.Create);
            StreamWriter = new StreamWriter(FileStream);

            StreamWriter.WriteLine("<html><head><style>.firstLine{font-weight: bold;} " +
                ".line {display: flex;flex-direction: row-reverse;}" +
                ".line p{ text-align: center; "+
                "width: 12%; }.left{" +
                "text-align: left;}</style></head><body>");
        }
        private string WriteUserToFile(UserDto user)
        {
            newFile(user.FirstName+" "+user.LastName);
           return "<p class='left'>"+DateTime.Today.ToString("dd/MM/yy")+"</p><div style='text-align:right;'><div style='font-weight:bold'> שלום " +
                user.FirstName + " </div><br>" +
                "טלפון: " + user.Fhon + "<br>" +
                "לפי הפרטים הרשומים במערכת הגשת בקשת לתשלום מס לפי הפרטים הנל<br>";
        }


        public string bodyWrite(int idFlight)
        {
            
            InformaDto informaDto = allSubject.selectInformaitionn(idFlight);
            using (FlightsEntities db = new FlightsEntities())
            {
                string header = WriteUserToFile(Convertion.UserConvertion.convertUserTODto(db.Users.FirstOrDefault(x => x.Id == informaDto.FlightInforDto.IdUser)));
                StreamWriter.WriteLine(header);
            }
            StreamWriter.WriteLine(FlightInformationConvrtion.stringLine(informaDto.FlightInforDto));

            StreamWriter.WriteLine(InformatinConvertion.stringLineHeader());
            informaDto.listInformation.ForEach(x =>
            {
                StreamWriter.WriteLine(InformatinConvertion.stringLine(x));
            });

            StreamWriter.WriteLine("<p style='text-align: center'> לבקשה זו צרפו " + informaDto.listFieles.Count() + " מסמכים </P>");
            StreamWriter.WriteLine("<div class='left'><p>בברכה</p><p>צוות ההנהלה</p></div>");
            StreamWriter.Close();
            StreamReader reader = new StreamReader(path,Encoding.UTF8);
            string body = reader.ReadToEnd();
            reader.Close();
            return body;
            

        }

    }
}
