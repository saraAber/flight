using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace WebApplication1.Controllers
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

            int id = user.Id;
            string username = user.UserName;
            string d = user.Password;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (UserService.PostUser(user) == null)
            {
                return BadRequest();
            }

            return CreatedAtRoute("DefaultApi", new { id = user.Id }, user);
        }
    }
}
