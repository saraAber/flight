using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.Convertion
{
    public class UserConvertion
    {

        public static UserDto convertUserTODto(User user)
        {
            UserDto userDto = new UserDto();
            userDto.EditDate = user.EditDate;
            userDto.Email = user.Email;
            userDto.Fhon = user.Fhon;
            userDto.FirstName = user.FirstName;
            userDto.Id = user.Id;
            userDto.LastName = user.LastName;
            userDto.LoginDate = user.LoginDate;
            userDto.Password = user.Password;
            userDto.UserName = user.UserName;

            return userDto;
        }
        public static User converuserDtoToUser(UserDto user)
        {
            User userDto = new User();
            userDto.EditDate = user.EditDate;
            userDto.Email = user.Email;
            userDto.Fhon = user.Fhon;
            userDto.FirstName = user.FirstName;
            userDto.Id = user.Id;
            userDto.LastName = user.LastName;
            userDto.LoginDate = user.LoginDate;
            userDto.Password = user.Password;
            userDto.UserName = user.UserName;

            return userDto;
        }

    }
}
