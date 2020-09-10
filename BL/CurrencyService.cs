using DTO;
using System;
using System.IO;
using System.Net;
namespace BL
{
    public class CurrencyService
    {
        public static object getCurrcy()
        {
            HttpWebRequest reqest = (HttpWebRequest)WebRequest.Create("http://www.boi.org.il/currency.xml");
            reqest.Method = "GET";


            HttpWebResponse getResponse = (HttpWebResponse)reqest.GetResponse();
            Stream stream = getResponse.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            var result = sr.ReadToEnd();
            return result;








        }

       
    }
}
