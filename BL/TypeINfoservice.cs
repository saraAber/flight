using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public class TypeINfoservice
    {
        public static List<TypeInfoDto> Get()
        {
            using (FlightsEntities db = new FlightsEntities())
            {
                return db.TypeInfoes.ToList().Select(x => Convertion.TypeInfoConvertien.ConvertTypeInfoToDto(x)).ToList();
            }
        }
    }
}
