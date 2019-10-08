using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learn_Net_Core_ASP.Models;

namespace Learn_Net_Core_ASP.Data {
    public class MockMovieRepository : IMovieRepository {
        public Movie GetById(int movieId) {
            return Movies().Where(m => m.id == movieId).FirstOrDefault();
            //throw new NotImplementedException();
        }

        public IEnumerable<Movie> Movies() =>
            new List<Movie> {
                new Movie{id=0,title = "Movie Name", releaseYear=2019,blurb="A short desc",language="English",genre="Sci Fi"},
                new Movie{id=1, title="Ad Astra",releaseYear=2019, blurb="d Astra takes a visually thrilling journey through the vast reaches of space while charting an ambitious course for the heart of the bond between parent and child.",language="English",genre="Sci Fi" }
            };
        
    }
}
