using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplicationDem.Models;

namespace WebApplicationDem.Controllers
{
    [ApiController]
    [Route("/api/actors")]
    public class ActorsController : ControllerBase
    {
        private List<Actor> Actors { get; set; }

        public ActorsController()
        {
            Actors = new List<Actor>()
            {
                new Actor() {Id = 1, FirstName = "Daniel", LastName = "Radcliffe", Age = 33},
                new Actor() {Id = 2, FirstName = "Emilia", LastName = "Clarke", Age = 33},
                new Actor() {Id = 3, FirstName = "Olivia", LastName = "Cooke", Age = 28},
                new Actor() {Id = 4, FirstName = "Ed", LastName = "Westwick", Age = 35},
                new Actor() {Id = 5, FirstName = "Tom", LastName = "Hardy", Age = 45},
            };
        }
        
        [HttpGet]
        public ActionResult GetAllActors()
        {
            return Ok(Actors);
        }
    }
}