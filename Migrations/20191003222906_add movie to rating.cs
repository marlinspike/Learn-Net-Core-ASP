using Microsoft.EntityFrameworkCore.Migrations;

namespace Learn_Net_Core_ASP.Migrations
{
    public partial class addmovietorating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Movies_Movieid",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "Movieid",
                table: "Ratings",
                newName: "movieid");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_Movieid",
                table: "Ratings",
                newName: "IX_Ratings_movieid");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Movies_movieid",
                table: "Ratings",
                column: "movieid",
                principalTable: "Movies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Movies_movieid",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "movieid",
                table: "Ratings",
                newName: "Movieid");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_movieid",
                table: "Ratings",
                newName: "IX_Ratings_Movieid");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Movies_Movieid",
                table: "Ratings",
                column: "Movieid",
                principalTable: "Movies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
