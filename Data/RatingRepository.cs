using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learn_Net_Core_ASP.Models;
using Microsoft.EntityFrameworkCore;

namespace Learn_Net_Core_ASP.Data {
    public class RatingRepository : IRatingRepository {

        public AppDbContext context { get; }
        public RatingRepository(AppDbContext appDbContext) {
            this.context = appDbContext;
        }
        public IEnumerable<Rating> GetRatingsForMovie(int movieId) {
            return context.Ratings.Include(r => r.movie_id == movieId) ;
            //throw new NotImplementedException();
        }

        public IEnumerable<Rating> Ratings() {
            return context.Ratings;
            //throw new NotImplementedException();
        }
    }
}
