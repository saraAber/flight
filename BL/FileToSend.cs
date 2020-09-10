using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class FileToSend
    {
        public static string ObjectToCsvData(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj", "Value can not be null or Nothing!");
            }

            StringBuilder sb = new StringBuilder();
            Type t = obj.GetType();
            PropertyInfo[] pi = t.GetProperties();

            for (int index = 0; index < pi.Length; index++)
            {
              
                switch (pi[index].Name)
                {
                    case "Id":  break;
                    case "IdUser":  break;
                    case "UserName": break;
                    case "From": sb.Append(" : מקום יציאה" + pi[index].GetValue(obj, null)+ "\n"); break;
                    case "ToPlice": sb.Append(" : מקום יעד" + pi[index].GetValue(obj, null)+ "\n"); break;
                    case "TZUser": sb.Append(" : תעודת זהות" + pi[index].GetValue(obj, null)+ "\n"); break;
                    case "StartDate": sb.Append(" : תאריך יציאה" + pi[index].GetValue(obj, null)+ "\n"); break;
                    case "BackDate": sb.Append(" : תאריך חזרה" + pi[index].GetValue(obj, null)+ "\n"); break;
                    case "Dates": sb.Append(" : מספר ימים" + pi[index].GetValue(obj, null)+ "\n"); break;
                    default: sb.Append(pi[index].Name +" :"+ pi[index].GetValue(obj, null) + "\n");break;

                }
            }
            sb.Append("נשלח עותק למעסיק ולך");
            return sb.ToString();
        }


    }
}
