using Microsoft.AspNetCore.Mvc;
using Semana2.Models;

namespace Semana2.Controllers
{
    public class MovieController : Controller
    {
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                //Simulación de creación de un objeto (model)
                //Mas adelante vamos a ver como usar una base de datos
                var movie = new Movie
                {
                    Genre = "Terror",
                    Id = 1,
                    Price = 1,
                    ReleaseDate = DateTime.Now,
                    Title = "La noche del terror"
                };


                return View(movie);
            }
            public async Task<IActionResult> Index()
            {
                var listMovies = new List<Movie>();

                var movie1 = new Movie
                {
                    Genre = "Terror",
                    Id = 2,
                    Price = 30,
                    ReleaseDate = DateTime.Now,
                    Title = "La noche del terror 2"
                };
                listMovies.Add(movie1);

                var movie2 = new Movie
                {
                    Genre = "Comedia",
                    Id = 3,
                    Price = 50,
                    ReleaseDate = DateTime.Now,
                    Title = "La casita del horror"
                };
                listMovies.Add(movie2);

                return View(listMovies);

            }
        }
    }