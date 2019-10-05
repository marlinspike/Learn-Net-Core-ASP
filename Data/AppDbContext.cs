using Learn_Net_Core_ASP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learn_Net_Core_ASP.Data {
    public class AppDbContext: DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder) {
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Movie>().HasData(new Movie { id = 2, blurb = "blah", genre = "Blah", language = "En:US",  releaseDate = new DateTime(2000,1,1), releaseYear = 2000, title = "Blat Title" });
        //}

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
