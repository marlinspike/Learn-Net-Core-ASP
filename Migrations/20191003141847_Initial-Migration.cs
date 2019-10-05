using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Learn_Net_Core_ASP.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: true),
                    releaseDate = table.Column<DateTime>(nullable: false),
                    releaseYear = table.Column<int>(nullable: false),
                    blurb = table.Column<string>(nullable: true),
                    language = table.Column<string>(nullable: true),
                    genre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rating = table.Column<int>(nullable: false),
                    review = table.Column<string>(nullable: true),
                    movie_id = table.Column<int>(nullable: false),
                    movieid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ratings_Movies_movieid",
                        column: x => x.movieid,
                        principalTable: "Movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_movieid",
                table: "Ratings",
                column: "movieid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
