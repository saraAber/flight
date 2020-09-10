using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class MailSend
    {
        public static string send(string Maill, int idFlight)
        {
            using (MailMessage mm = new MailMessage("sara5780272@gmail.com", Maill))
            {
                fileStream body = new fileStream();
                mm.IsBodyHtml = true;
                mm.Body=body.bodyWrite(idFlight);
              
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Timeout = 30 * 1000;
                client.Credentials = new NetworkCredential("sara5780272@gmail.com", "0556783732");
                client.Port = 587;
                client.EnableSsl = true;
                try
                {
                    client.Send(mm);
                    return "המייל נשלח בהצלחה";
                }
                catch
                {
                    return mm.Body;
                }




            }
        }
    }
}
