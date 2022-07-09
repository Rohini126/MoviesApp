using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieServices.Interface;
using MovieServices.MovieDAL.CustomModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieServices.Controller
{
    public class MovieController : ControllerBase
    {
		private readonly IMovie Movie;
	
		public MovieController(IMovie Movie)
		{
			this.Movie = Movie;
		}
		[HttpGet("viewMovies")]
		public IActionResult GetMovies()
		{
			try
			{
					var MovieList = Movie.GetMovies();
					if (MovieList == null)
					{
						return StatusCode(StatusCodes.Status404NotFound);
					}
					else
					{
						return StatusCode(StatusCodes.Status200OK, MovieList);
					}
				
			}
			catch (Exception ex)
			{
				throw;
			}
		}

		[HttpGet("CreateMovie")]
		public IActionResult CreateMovie([FromBody]CreateUpdateMovieDTO movieDTO)
		{
			try
			{
				var MovieCreate = Movie.CreateMovie(movieDTO);
				if (MovieCreate == 1)
				{
					return StatusCode(StatusCodes.Status200OK,"Movie Created Successfully");
				}
				else
				{
					return StatusCode(StatusCodes.Status400BadRequest, "Failed to create Movie");
				}

			}
			catch (Exception ex)
			{
				throw;
			}
		}

		[HttpGet("UpdateMovie")]
		public IActionResult UpdateMovie([FromBody] CreateUpdateMovieDTO movieDTO)
		{
			try
			{
				var movieUpdate = Movie.UpdateMovie(movieDTO);
				if (movieUpdate == 1)
				{
					return StatusCode(StatusCodes.Status200OK, "Movie Updated Successfully");
				}
				else
				{
					return StatusCode(StatusCodes.Status400BadRequest, "Failed to Update Movie");
				}

			}
			catch (Exception ex)
			{
				throw;
			}
		}

		[HttpGet("CreateActor")]
		public IActionResult CreateActor([FromBody] CreateActor actorDTO)
		{
			try
			{
				var actor = Movie.CreateActor(actorDTO);
				if (actor == 1)
				{
					return StatusCode(StatusCodes.Status200OK, "Actor Created Successfully");
				}
				else
				{
					return StatusCode(StatusCodes.Status400BadRequest, "Failed to create Actor");
				}

			}
			catch (Exception ex)
			{
				throw;
			}
		}

		[HttpGet("CreateProducer")]
		public IActionResult CreateProducer([FromBody] CreateProducer ProducerDTO)
		{
			try
			{
				var producer = Movie.CreateProducer(ProducerDTO);
				if (producer == 1)
				{
					return StatusCode(StatusCodes.Status200OK, "Producer Created Successfully");
				}
				else
				{
					return StatusCode(StatusCodes.Status400BadRequest, "Failed to create Producer");
				}

			}
			catch (Exception ex)
			{
				throw;
			}
		}
	}
}
