using Microsoft.EntityFrameworkCore;
using MovieApp.Data.DataConnection;
using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieApp.Data.Repositories
{
    public class Theatre : ITheatre
    {
        MovieDbContext _movieDbContext;

        public Theatre(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }


        //crud Operations
        public string AddTheatre(TheatreModel theatreModel)
        {
            string message = "";
            _movieDbContext.theatreModel.Add(theatreModel);
            _movieDbContext.SaveChanges();
            message = "theatre Added Successfully..!!";
            return message;
        }

        public object SelectTheatre()
        {
            List<TheatreModel> theatreList = _movieDbContext.theatreModel.ToList();
            return theatreList;
        }

        public string EditTheatre(TheatreModel theatreModel)
        {
            _movieDbContext.Entry(theatreModel).State = EntityState.Modified;
            _movieDbContext.SaveChanges();
            return "theatre Details Update Successfully..!!";
        }

        public string DeleteTheatre(int id)
        {
            TheatreModel foundtheatre = _movieDbContext.theatreModel.Find(id);
            _movieDbContext.theatreModel.Remove(foundtheatre);
            _movieDbContext.SaveChanges();
            return "theatre Deleted Successfully..!!";
        }

        public object FetchTheatreById(int id)
        {
            TheatreModel foundtheatre = _movieDbContext.theatreModel.Find(id);
            if (foundtheatre != null)
            {
                return foundtheatre;
            }
            else
            {
                return "Sorry..theatre Not Found..!!";
            }
        }
    }
}
