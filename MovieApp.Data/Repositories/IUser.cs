using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Entity;

namespace MovieApp.Data.Repositories
{
    public interface IUser
    {
        public string Delete(int id);

        public object Login(UserModel userModel);

        public string RegisterUser(UserModel userModel);

        public object SelectUsers();

        public string Update(UserModel userModel);
        public object FindUserById(int id);
    }
}
