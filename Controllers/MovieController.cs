using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learn_Net_Core_ASP.Data;
using Learn_Net_Core_ASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace Learn_Net_Core_ASP.Controllers
{
    public class MovieController : Controller {
        public readonly IMovieRepository _movieRepository;
        public readonly IRatingRepository _ratingRepository;

        private readonly AppDbContext _context;


        public MovieController(IMovieRepository movieRepository, IRatingRepository ratingRepository, AppDbContext context) {
            _movieRepository = movieRepository;
            _ratingRepository = ratingRepository;
            _context = context;
        }

        public ViewResult List() {
            ViewBag.Message = "Welcome to the Movies app";
            return View(_movieRepository.Movies());
        }

        public ViewResult Edit(int movieId) {
            var movie = _movieRepository.GetById(movieId);
            ViewBag.Message = "Welcome to the Movies app";
            return View(movie);
        }

        public IActionResult Index() {
            var movies = _movieRepository.Movies();
            return View(movies);
        }



    }
}