using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Convertion
{
    class TypeInfoConvertien
    {
        public static TypeInfoDto ConvertTypeInfoToDto(TypeInfo Type)
        {
            TypeInfoDto newType = new TypeInfoDto();
            newType.Id = Type.Id;
            newType.Type = Type.Type;
            return newType;
        }
    }
}
