using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplicationDem.Models;

namespace WebApplicationDem.Controllers
{
    [ApiController]
    [Route("/api/movies")]
    public class MoviesController : ControllerBase
    {
        private List<Movie> Movies { get; set; }

        public MoviesController()
        {
            Movies = new List<Movie>()
            {
                new Movie() {Id = 1, Title = "Harry Potter", Year = 2001},
                new Movie() {Id = 2, Title = "Me Before You", Year = 2016},
                new Movie() {Id = 3, Title = "The Limehouse Golem", Year = 2016},
                new Movie() {Id = 4, Title = "Chalet Girl", Year = 2011},
                new Movie() {Id = 5, Title = "Venom", Year = 2018}
            };
        }
        [HttpGet]
        public ActionResult GetAllMovies()
        {
            return Ok(Movies);
        }
    }
}