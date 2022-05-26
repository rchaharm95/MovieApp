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

        public string Register(UserModel userModel)
        {
            return _iuser.Register(userModel);
        }

        public object SelectUser()
        {
            return _iuser.SelectUsers();
        }

        public string DeleteUser(int id)
        {
            return _iuser.Delete(id);
        }

    }
}
