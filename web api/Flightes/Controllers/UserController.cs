using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BL;
using System.Web.Http.Description;

namespace Flightes.Controllers
{
    public class UserController : ApiController
    {
        public List<UserDto> GetUsers()
        {
            return UserService.GetAllUsers();
        }



        [ResponseType(typeof(UserDto))]
        public IHttpActionResult GetUser(string userName, string password)
        {
            UserDto user = new UserDto();
            user = UserService.getUser(password, userName);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [ResponseType(typeof(void))]
        public IHttpActionResult PutUser(int id, UserDto user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != user.Id)
            {
                return BadRequest();
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        [ResponseType(typeof(UserDto))]

        [HttpPost]
        public IHttpActionResult PostUser(UserDto user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
             if (user != null)
            {
                if (!UserService.UserNameExith(user.UserName))
                {
                    return BadRequest("קיים כבר שם משתמש במערכת");
                }
                if (!UserService.emailExith(user.Email))
                {
                    return BadRequest("קיים כבר כתובת מייל זה במערכת");
                }
                if (UserService.PostUser(user) == null)
            {
                return BadRequest();
            }
          

                return Ok(UserService.PostUser(user));

            }
            return BadRequest("חסרים נתונים");
        }

    }
}
