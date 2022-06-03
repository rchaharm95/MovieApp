using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Data.Migrations
{
    public partial class movie2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieBooking",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    MovieModelMovieId = table.Column<int>(type: "int", nullable: true),
                    TheatreId = table.Column<int>(type: "int", nullable: false),
                    TheatreModelTheatreId = table.Column<int>(type: "int", nullable: true),
                    MovieShowTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ticketCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieBooking", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_MovieBooking_movieModel_MovieModelMovieId",
                        column: x => x.MovieModelMovieId,
                        principalTable: "movieModel",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieBooking_theatreModel_TheatreModelTheatreId",
                        column: x => x.TheatreModelTheatreId,
                        principalTable: "theatreModel",
                        principalColumn: "TheatreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieBooking_userModel_UserId",
                        column: x => x.UserId,
                        principalTable: "userModel",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieTime",
                columns: table => new
                {
                    MovieTimeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    MovieModelMovieId = table.Column<int>(type: "int", nullable: true),
                    TheatreId = table.Column<int>(type: "int", nullable: false),
                    TheatreModelTheatreId = table.Column<int>(type: "int", nullable: true),
                    ShowTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieTime", x => x.MovieTimeId);
                    table.ForeignKey(
                        name: "FK_MovieTime_movieModel_MovieModelMovieId",
                        column: x => x.MovieModelMovieId,
                        principalTable: "movieModel",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieTime_theatreModel_TheatreModelTheatreId",
                        column: x => x.TheatreModelTheatreId,
                        principalTable: "theatreModel",
                        principalColumn: "TheatreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieBooking_MovieModelMovieId",
                table: "MovieBooking",
                column: "MovieModelMovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieBooking_TheatreModelTheatreId",
                table: "MovieBooking",
                column: "TheatreModelTheatreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieBooking_UserId",
                table: "MovieBooking",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieTime_MovieModelMovieId",
                table: "MovieTime",
                column: "MovieModelMovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieTime_TheatreModelTheatreId",
                table: "MovieTime",
                column: "TheatreModelTheatreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieBooking");

            migrationBuilder.DropTable(
                name: "MovieTime");
        }
    }
}
