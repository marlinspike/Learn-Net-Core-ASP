using Learn_Net_Core_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learn_Net_Core_ASP.Data {
    public interface IRatingRepository {
        public IEnumerable<Rating> Ratings();
        public IEnumerable<Rating> GetRatingsForMovie(int movieId);
    }
}
