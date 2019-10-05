using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learn_Net_Core_ASP.Data;
using Learn_Net_Core_ASP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Learn_Net_Core_ASP.Controllers
{
    public class MoviesController : Controller{

        public readonly IMovieRepository _movieRepository;
        private readonly IRatingRepository _ratingRepository;
        private readonly AppDbContext _context;

        public MoviesController(IMovieRepository movieRepository, IRatingRepository ratingRepository, AppDbContext context) {
            _movieRepository = movieRepository;
            _ratingRepository = ratingRepository;
            _context = context;
        }


        // GET: Movies
        public ActionResult Index(){
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        // GET: Movies/Details/5
        public ActionResult Details(int id){
            var movie = _context.Movies.Include(r=>r.rating).Where(m => m.id == id).FirstOrDefaultAsync();
            return View(movie.Result);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("title", "releaseDate", "releaseYear","blurb","language","genre")]Movie newMovie){
            try {
                _context.Movies.Add(newMovie);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movies/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}