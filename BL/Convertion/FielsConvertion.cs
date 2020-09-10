using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Convertion
{
    class FielsConvertion
    {
        public static FielesDto ConvertFileToDto(file file)
        {
            FielesDto newFile = new FielesDto();
            newFile.FileName = file.FileName;
            newFile.Id = file.Id;
            newFile.intInfor = file.intInfor;
            newFile.Pathname = file.Pathname;
            newFile.Size = file.Size;
            newFile.Type = file.Type;
            return newFile;
        }
        public static file ConvertFileToDto(FielesDto file)
        {
            file newFile = new file();
            newFile.FileName = file.FileName;
            newFile.Id = file.Id;
            newFile.intInfor = file.intInfor;
            newFile.Pathname = file.Pathname;
            newFile.Size = file.Size;
            newFile.Type = file.Type;
            return newFile;
        }
    }
}
