using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learn_Net_Core_ASP.Models;
using Microsoft.EntityFrameworkCore;

namespace Learn_Net_Core_ASP.Data {
    public class MovieRepository : IMovieRepository {

        public AppDbContext context { get; }
        public MovieRepository(AppDbContext appDbContext) {
            this.context = appDbContext;
        }
        public Movie GetById(int movieId) {
            return context.Movies.FirstOrDefault(m => m.id == movieId);
            //throw new NotImplementedException();
        }

        public IEnumerable<Movie> Movies() {
            var movies = context.Movies.Include(m => m.rating);
            return movies;
            //throw new NotImplementedException();
        }
    }
}
