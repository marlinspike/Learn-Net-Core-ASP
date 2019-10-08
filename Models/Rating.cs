using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learn_Net_Core_ASP.Models {
    public class Rating {
        public int id { get; set; }
        public int rating { get; set; }
        public string review { get; set; }

        public int movie_id { get; set; }
        public Movie movie { get; set; }
    }
}
