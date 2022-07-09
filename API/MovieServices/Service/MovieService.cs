using Microsoft.EntityFrameworkCore;
using MovieServices.Interface;
using MovieServices.MovieDAL.CustomModels;
using MovieServices.MovieDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieServices.Service
{
    class MovieService : IMovie
    {
        public List<MovieList> GetMovies()
        {
            try
            {
                using(var context = Context.GetContext())
                {
                    var listOfMovies = context.Movie.Include(x => x.ProducerX).Where(x => x.status == 1).Select(item => new MovieList
                    {
                        MovieId = item.MovieId,
                        MovieName = item.MovieName,
                        MoviePlot = item.MoviePlot,
                        producerName = (item.ProducerX != null)? item.ProducerX.ProducerName : null,
                        posterData = item.PosterData,
                        releasedate = Convert.ToString(item.ReleaseDate),

                    }).ToList();
                    if(listOfMovies != null && listOfMovies.Count > 0)
                    {
                        foreach(var item in listOfMovies)
                        {
                            var actors = context.MovieActorMapping.Include(x => x.ActorX).Where(x => x.MovieXid == item.MovieId).Select(item => item.ActorX.Actorname).ToList();
                            item.Actors = actors;
                        }
                    }

                    return listOfMovies;

                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }  

        public int CreateMovie(CreateUpdateMovieDTO movie)
        {
            try
            {
                using(var context = Context.GetContext())
                {
                    var movieItem = new Movie();
                    movieItem.MovieName = movie.MovieName;
                    movieItem.MoviePlot = movie.MoviePlot;
                    movieItem.PosterData = movie.posterData;
                    movieItem.ProducerXid = movie.producerId;
                    movieItem.ReleaseDate = Convert.ToDateTime(movie.releasedate);
                    movieItem.CreationDate = DateTime.UtcNow;
                    movieItem.ModificationDate = DateTime.UtcNow;

                    context.Movie.Add(movieItem);
                    context.SaveChanges();
                    var MovieId = movieItem.MovieId;
                    if(movie.ActorId != null && movie.ActorId.Count > 0)
                    {
                        foreach (var item in movie.ActorId)
                        {
                            var movieActor = new MovieActorMapping();
                            movieActor.ActorXid = item;
                            movieActor.MovieXid = MovieId;
                            context.MovieActorMapping.Add(movieActor);
                        }
                        context.SaveChanges();
                    }
                    return 1;
                }
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public int UpdateMovie(CreateUpdateMovieDTO movie)
        {
            try
            {
               using(var context = Context.GetContext())
               {
                    //Removing the previously save actor,movie mapping
                    var movieActors = context.MovieActorMapping.Where(x => x.MovieXid == movie.MovieId).ToList();
                    if(movieActors!= null && movieActors.Count > 0)
                    {
                        context.MovieActorMapping.RemoveRange(movieActors);
                        context.SaveChanges();
                    }
                    var movieItem = context.Movie.FirstOrDefault(x => x.MovieId == movie.MovieId);
                    movieItem.MovieName = movie.MovieName;
                    movieItem.MoviePlot = movie.MoviePlot;
                    movieItem.PosterData = movie.posterData;
                    movieItem.ProducerXid = movie.producerId;
                    movieItem.ReleaseDate = Convert.ToDateTime(movie.releasedate);
                    movieItem.ModificationDate = DateTime.UtcNow;

                    context.Movie.Update(movieItem);
                    context.SaveChanges();
                    var MovieId = movie.MovieId;
                    if (movie.ActorId != null && movie.ActorId.Count > 0)
                    {
                        foreach (var item in movie.ActorId)
                        {
                            var movieActor = new MovieActorMapping();
                            movieActor.ActorXid = item;
                            movieActor.MovieXid = MovieId;
                            context.MovieActorMapping.Add(movieActor);
                        }
                        context.SaveChanges();
                    }
                    return 1;

                }
            }
            catch(Exception ex)
            {
                return 0;
            }
        }  

        public int CreateActor(CreateActor actor)
        {
            try
            {
                using(var context = Context.GetContext())
                {
                    var ActorItem = new Actor();
                    ActorItem.Actorname = actor.Actorname;
                    ActorItem.ActorBio = actor.ActorBio;
                    ActorItem.DateOfBirth = Convert.ToDateTime(actor.dateOfbirth);
                    ActorItem.Gender = actor.Gender;
                    ActorItem.CreationDate = DateTime.UtcNow;
                    ActorItem.ModificationDate = DateTime.UtcNow;
                    context.Actor.Add(ActorItem);
                    context.SaveChanges();

                    return 1;
                }

            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public int CreateProducer(CreateProducer Producer)
        {
            try
            {
                using (var context = Context.GetContext())
                {
                    var ProducerItem = new Producer();
                    ProducerItem.ProducerName = Producer.Producername;
                    ProducerItem.producerBio = Producer.ProducerBio;
                    ProducerItem.dateOfBirth = Convert.ToDateTime(Producer.dateOfbirth);
                    ProducerItem.Gender = Producer.Gender;
                    ProducerItem.Companyname = Producer.companyname;
                    ProducerItem.CreationDate = DateTime.UtcNow;
                    ProducerItem.ModificationDate = DateTime.UtcNow;
                    context.Producer.Add(ProducerItem);
                    context.SaveChanges();

                    return 1;
                }

            }
            catch (Exception ex)
            {
                return 0;
            }
        }


    }
}
