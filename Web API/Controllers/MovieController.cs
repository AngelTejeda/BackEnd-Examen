using Data.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MoviesContext _dbContext;

        public MovieController(MoviesContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<MovieController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Movie> movies = _dbContext.Movies.ToList();

            return Ok(movies);
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Movie movie = _dbContext.Movies.FirstOrDefault(movie => movie.MovieId == id);

            if (movie == null)
                return NotFound();

            return Ok(movie);
        }

        // POST api/<MovieController>
        [HttpPost]
        public IActionResult Post([FromBody] Movie newMovie)
        {
            if (newMovie.MovieId != 0)
                return BadRequest("The ID of the movie cannot be specified when posting a new movie.");

            int id;

            _dbContext.Movies.Add(newMovie);
            _dbContext.SaveChanges();

            id = newMovie.MovieId;

            return Created($"GET {Request.Path}/{ControllerContext.ActionDescriptor.ControllerName}/{id}", id);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Movie modifiedMovie)
        {
            if (id < 1)
                return BadRequest("MovieId must be at least 1.");

            if (id != modifiedMovie.MovieId)
                return BadRequest("MovieId cannot be modified.");

            Movie dbMovie = _dbContext.Movies.AsNoTracking().FirstOrDefault(movie => movie.MovieId == id);

            if (dbMovie == null)
                return NotFound();

            _dbContext.Entry(modifiedMovie).State = EntityState.Modified;
            _dbContext.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 1)
                return BadRequest("MovieId must be at least 1.");

            Movie dbMovie = _dbContext.Movies.FirstOrDefault(movie => movie.MovieId == id);

            if (dbMovie == null)
                return NotFound();

            _dbContext.Remove(dbMovie);
            _dbContext.SaveChanges();

            return Ok(dbMovie);
        }
    }
}
