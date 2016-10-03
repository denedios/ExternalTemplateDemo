using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using MovieGrid.Models;

namespace MovieGrid.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllMovies([DataSourceRequest]DataSourceRequest request)
        {
            var movies = new List<Movie>
            {
                new Movie
                {
                    MovieId = 1,
                    Title = "Miss Peregrine's Home for Peculiar Children",
                    Description = "When Jacob discovers clues to a mystery that stretches across time, he finds Miss Peregrine's Home for Peculiar Children. But the danger deepens after he gets to know the residents and learns about their special powers.",
                    ReleaseDate = string.Format("{0:d}", new DateTime(2016, 9, 30)),
                    Rating = "PG-13",
                    Director = "Tim Burton",
                    Genre = "Adventure, Fantasy",
                    Length = "2h 7min"
                },
                new Movie
                {
                    MovieId = 2,
                    Title = "The Shawshank Redemption",
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    ReleaseDate = string.Format("{0:d}", new DateTime(1994, 10, 14)),
                    Rating = "R",
                    Director = "Frank Darabont",
                    Genre = "Crime, Drama",
                    Length = "2h 22min"
                },
                new Movie
                {
                    MovieId = 3,
                    Title = "The Godfather",
                    Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                    ReleaseDate = string.Format("{0:d}", new DateTime(1972, 3, 24)),
                    Rating = "R",
                    Director = "Francis Ford Coppola",
                    Genre = "Crime, Drama",
                    Length = "2h 55min"
                },
                new Movie
                {
                    MovieId = 4,
                    Title = "The Dark Knight",
                    Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, the caped crusader must come to terms with one of the greatest psychological tests of his ability to fight injustice.",
                    ReleaseDate = string.Format("{0:d}", new DateTime(2008, 7, 18)),
                    Rating = "PG-13",
                    Director = "Christopher Nolan",
                    Genre = "Action, Crime, Drama",
                    Length = "2h 32min"
                },
                new Movie
                {
                    MovieId = 5,
                    Title = "Pulp Fiction",
                    Description = "The lives of two mob hit men, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    ReleaseDate = string.Format("{0:d}", new DateTime(1994, 10, 14)),
                    Rating = "R",
                    Director = "Quentin Tarantino",
                    Genre = "Crime, Drama",
                    Length = "2h 34min"
                }
            };

            return Json(movies.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }
    }
}