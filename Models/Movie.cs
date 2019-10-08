using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learn_Net_Core_ASP.Models {
    public class Movie {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime releaseDate { get; set; }
        public int releaseYear { get; set; }
        public string blurb { get; set; }
        public string language { get; set; }
        public string genre { get; set; }
        public ICollection<Rating> rating { get; set; }

    }
}
