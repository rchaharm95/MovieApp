using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Entity;

namespace MovieApp.Data.Repositories
{
    public interface IUser
    {
        public string Delete(int id);

        public object Login();

        public string Register(UserModel userModel);

        public object SelectUsers();

        public string Update();

    }
}
