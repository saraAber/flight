using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public static class UserService
    {
        public static List<UserDto> GetAllUsers()
        {
            using (FlightsEntities db = new FlightsEntities())
            {
                return db.Users.ToList().Select(x => Convertion.UserConvertion.convertUserTODto(x)).ToList();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pass"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static UserDto getUser(string pass, string userName)
        {
            using (FlightsEntities db = new FlightsEntities())
            {
                User userFind = new User();
                userFind = db.Users.ToList().FirstOrDefault(x => x.Password == pass && x.UserName == userName);

                if (userFind == null)
                {
                    return null;
                }
                userFind.EditDate = DateTime.Now;
                LoginUser userlog = new LoginUser();
                userlog.UserId = userFind.Id;
                userlog.LoginDate = DateTime.Now;
                db.LoginUsers.Add(userlog);
                db.SaveChanges();
                return Convertion.UserConvertion.convertUserTODto(userFind);
            }
        }
        public static UserDto PutUser(int id, User user)
        {
            using (FlightsEntities db = new FlightsEntities())
            {
                db.Entry(user).State = EntityState.Modified;
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(id))
                    {
                        return null;
                    }
                    else
                    {
                        throw;
                    }
                }
                return Convertion.UserConvertion.convertUserTODto(user);
            }
        }
        public static bool emailExith(string Mail)
        {
            using(FlightsEntities db=new FlightsEntities())
            {
                User find = new User();
                find=db.Users.ToList().FirstOrDefault(x => x.Email == Mail);
                return (find==null) ? true : false;
            }
        }
        public static bool UserNameExith(string userNmae)
        {
            using (FlightsEntities db = new FlightsEntities())
            {
                User find = new User();
                find = db.Users.ToList().FirstOrDefault(x => x.UserName == userNmae);
                return (find == null) ? true : false;
            }
        }
        public static UserDto PostUser(UserDto userDto)
        {
            User newUser = new User();
            newUser = Convertion.UserConvertion.converuserDtoToUser(userDto);
            using (FlightsEntities db = new FlightsEntities())
            {
                
                newUser.EditDate = DateTime.Now;
                newUser.LoginDate = DateTime.Now;
                db.Users.Add(newUser);
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    return null;
                }


            }
            return Convertion.UserConvertion.convertUserTODto(newUser);
        }
        private static bool UserExists(int id)
        {
            using (FlightsEntities db = new FlightsEntities())
            {
                return db.Users.Count(e => e.Id == id) > 0;
            }
        }


    }
}
