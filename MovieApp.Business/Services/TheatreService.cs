using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Data.Repositories;
using MovieApp.Entity;

namespace MovieApp.Business.Services
{
    public class TheatreService
    {
        ITheatre theatre;
        
        public TheatreService(ITheatre theatre)
        {
            this.theatre = theatre;
        }

        public string AddTheatre(TheatreModel theatreModel)
        {
            return theatre.AddTheatre(theatreModel);
        }

        public object SelectTheatre()
        {
            return theatre.SelectTheatre();
        }
    }
}
