using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Data.Repositories;
using MovieApp.Entity;

namespace MovieApp.Business.Services
{
    public class UserService
    {
        IUser _iuser;
        public UserService(IUser iuser)
        {
            _iuser = iuser;
        }

        public string RegisterUser(UserModel userModel)
        {
            return _iuser.RegisterUser(userModel);
        }

        public object SelectUser()
        {
            return _iuser.SelectUsers();
        }

        public string DeleteUser(int id)
        {
            return _iuser.Delete(id);
        }

        public object Login(UserModel userModel)
        {
            return _iuser.Login(userModel);
        }

        public object FindUserById(int id)
        {
            return _iuser.FindUserById(id);
        }

        public string EditUser(UserModel userModel)
        {
            return _iuser.Update(userModel);
        }

        
    }
}
