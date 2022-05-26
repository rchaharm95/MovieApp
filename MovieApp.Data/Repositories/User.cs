using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public object Login()
        {
            throw new NotImplementedException();
        }

        public string Register(UserModel userModel)
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

        public string Update()
        {
            throw new NotImplementedException();
        }
    }
}
