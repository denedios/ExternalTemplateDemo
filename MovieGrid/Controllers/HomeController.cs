using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MovieGrid.Models;

namespace MovieGrid.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllMovies()
        {
            var movies = new List<Movie>
            {
                new Movie
                {
                    MovieId = 1,
                    Title = "Miss Peregrine's Home for Peculiar Children",
                    Description = "When Jacob discovers clues to a mystery that stretches across time, he finds Miss Peregrine's Home for Peculiar Children. But the danger deepens after he gets to know the residents and learns about their special powers.",
                    ReleaseDate = new DateTime(2016, 9, 30)
                },
                new Movie
                {
                    MovieId = 2,
                    Title = "The Shawshank Redemption",
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    ReleaseDate = new DateTime(1994, 10, 14)
                },
                new Movie
                {
                    MovieId = 3,
                    Title = "The Godfather",
                    Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                    ReleaseDate = new DateTime(1972, 3, 24)
                },
                new Movie
                {
                    MovieId = 4,
                    Title = "The Dark Knight",
                    Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, the caped crusader must come to terms with one of the greatest psychological tests of his ability to fight injustice.",
                    ReleaseDate = new DateTime(2008, 7, 18)
                },
                new Movie
                {
                    MovieId = 1,
                    Title = "Pulp Fiction",
                    Description = "The lives of two mob hit men, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    ReleaseDate = new DateTime(1994, 10, 14)
                }
            };

            return Json(movies, JsonRequestBehavior.AllowGet);
        }
    }
}