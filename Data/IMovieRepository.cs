using Learn_Net_Core_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learn_Net_Core_ASP.Data {
    public interface IMovieRepository {
        public IEnumerable<Movie> Movies();
        public Movie GetById(int movieId);

    }
}
