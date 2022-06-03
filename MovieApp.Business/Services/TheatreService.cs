using MovieApp.Data.Repositories;
using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Business.Services
{
    public class TheatreService
    {
        ITheatre _itheatre;

        public TheatreService(ITheatre itheatre)
        {
            _itheatre = itheatre;
        }


        public Object SelectTheatre()
        {
            return _itheatre.SelectTheatre();
        }

        public string EditTheatre(TheatreModel theatreModel)
        {
            return _itheatre.EditTheatre(theatreModel);
        }

        public object AddTheatre(TheatreModel theatreModel)
        {
            return _itheatre.AddTheatre(theatreModel);
        }

        public string DeleteTheatre(int id)
        {
            return _itheatre.DeleteTheatre(id);
        }

        public object FetchTheatreById(int id)
        {
            return _itheatre.FetchTheatreById(id);
        }
    }
}
