using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data.DataConnection;
using MovieApp.Entity;

namespace MovieApp.Data.Repositories
{
    public class User : IUser
    {
        MovieDbContext _movieDbContext;
        public  User(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public string Delete(int id)
        {
            string message = "";
            var foundUser = _movieDbContext.userModel.Find(id);
            _movieDbContext.userModel.Remove(foundUser);
            _movieDbContext.SaveChanges();
            message = "user deleted successfully";
            return message;
        }

        public object Login(UserModel userModel)
        {
            UserModel validateduser = null;
            var foundUser = _movieDbContext.userModel.Where(u => u.Email.Equals(userModel.Email) && u.Password.Equals(userModel.Password)).ToList();
            if (foundUser.Count() > 0)
            {
                validateduser = foundUser[0];
                return validateduser;
            }
            else
            {
                return "User not Found..!!";
            }
        }

        public string RegisterUser(UserModel userModel)
        {
            string msg = "";
            _movieDbContext.userModel.Add(userModel);
            _movieDbContext.SaveChanges();
            msg = "Inserted";
            return msg;
        }

        public object SelectUsers()
        {
            List<UserModel> userList = _movieDbContext.userModel.ToList();
            return userList;
        }

        public string Update(UserModel userModel)
        {
            _movieDbContext.Entry(userModel).State = EntityState.Modified;
            _movieDbContext.SaveChanges();
            return "Data Updated";
        }

        public object FindUserById(int id)
        {
            var foundUser = _movieDbContext.userModel.Find(id);
            if (foundUser != null)
            {
                return foundUser;
            }
            else
            {
                return "User not Found..!!";
            }
        }
    }
}
