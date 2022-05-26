using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Entity;
using MovieApp.Data.DataConnection;
using System.Linq;

namespace MovieApp.Data.Repositories
{
    public class Theatre : ITheatre
    {
        MovieDbContext _movieDbContext;
        public Theatre(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }
        public string AddTheatre(TheatreModel theatreModel)
        {
            string msg = "";
            _movieDbContext.theatreModel.Add(theatreModel);
            _movieDbContext.SaveChanges();
            msg = "theatre added successfully";
            return msg;

        }

        public object SelectTheatre()
        {
            List<TheatreModel> theatreList = _movieDbContext.theatreModel.ToList();
            return theatreList;
        }
    }
}
