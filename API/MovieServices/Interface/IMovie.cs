using MovieServices.MovieDAL.CustomModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieServices.Interface
{
    public interface IMovie
    {
        List<MovieList> GetMovies();
        int CreateMovie(CreateUpdateMovieDTO movie);
        int UpdateMovie(CreateUpdateMovieDTO movie);
        int CreateActor(CreateActor actor);
        int CreateProducer(CreateProducer Producer);
    }
}
