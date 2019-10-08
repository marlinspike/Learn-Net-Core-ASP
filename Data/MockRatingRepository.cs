using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learn_Net_Core_ASP.Models;

namespace Learn_Net_Core_ASP.Data {
    public class MockRatingRepository : IRatingRepository {
        public Rating GetById(int ratingId) {
            return Ratings().FirstOrDefault(p => p.id == ratingId);
        }

        public Rating GetRatingsForMovie(int movieId) {
            return Ratings().FirstOrDefault(p => p.movie_id == movieId);
        }

        public IEnumerable<Rating> Ratings() =>
            new List<Rating> {
                new Rating{movie_id=0,rating=4,review="I liked it",},
                new Rating{movie_id=0,rating=2,review="Nah"},
                new Rating{movie_id=1,rating=5, review="Loved it!"},
                new Rating{movie_id=1,rating=3, review="I've seen better Brad Pitt movies!"}
            };

        IEnumerable<Rating> IRatingRepository.GetRatingsForMovie(int movieId) {
            return Ratings().Where(p => p.movie_id == movieId);
        }
    }
}
