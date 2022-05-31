using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Entity;

namespace MovieApp.Data.Repositories
{
    public interface ITheatre
    {
        string AddTheatre(TheatreModel theatreModel);

        object SelectTheatre();

        string EditTheatre(TheatreModel theatreModel);

        string DeleteTheatre(int id);

        object FetchTheatreById(int id);
    }
}
