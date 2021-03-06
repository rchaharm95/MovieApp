// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApp.Data.DataConnection;

namespace MovieApp.Data.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20220603153317_movie2")]
    partial class movie2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MovieApp.Entity.BookingModel", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("MovieDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int?>("MovieModelMovieId")
                        .HasColumnType("int");

                    b.Property<string>("MovieShowTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TheatreId")
                        .HasColumnType("int");

                    b.Property<int?>("TheatreModelTheatreId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ticketCount")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("MovieModelMovieId");

                    b.HasIndex("TheatreModelTheatreId");

                    b.HasIndex("UserId");

                    b.ToTable("MovieBooking");
                });

            modelBuilder.Entity("MovieApp.Entity.MovieModel", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("MovieDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("movieModel");
                });

            modelBuilder.Entity("MovieApp.Entity.ShowMovieTime", b =>
                {
                    b.Property<int>("MovieTimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int?>("MovieModelMovieId")
                        .HasColumnType("int");

                    b.Property<string>("ShowTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TheatreId")
                        .HasColumnType("int");

                    b.Property<int?>("TheatreModelTheatreId")
                        .HasColumnType("int");

                    b.HasKey("MovieTimeId");

                    b.HasIndex("MovieModelMovieId");

                    b.HasIndex("TheatreModelTheatreId");

                    b.ToTable("MovieTime");
                });

            modelBuilder.Entity("MovieApp.Entity.TheatreModel", b =>
                {
                    b.Property<int>("TheatreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("TheatreCapacity")
                        .HasColumnType("int");

                    b.Property<string>("TheatreLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TheatreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TheatreId");

                    b.ToTable("theatreModel");
                });

            modelBuilder.Entity("MovieApp.Entity.UserModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mobile")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("userModel");
                });

            modelBuilder.Entity("MovieApp.Entity.BookingModel", b =>
                {
                    b.HasOne("MovieApp.Entity.MovieModel", "MovieModel")
                        .WithMany()
                        .HasForeignKey("MovieModelMovieId");

                    b.HasOne("MovieApp.Entity.TheatreModel", "TheatreModel")
                        .WithMany()
                        .HasForeignKey("TheatreModelTheatreId");

                    b.HasOne("MovieApp.Entity.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieModel");

                    b.Navigation("TheatreModel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MovieApp.Entity.ShowMovieTime", b =>
                {
                    b.HasOne("MovieApp.Entity.MovieModel", "MovieModel")
                        .WithMany()
                        .HasForeignKey("MovieModelMovieId");

                    b.HasOne("MovieApp.Entity.TheatreModel", "TheatreModel")
                        .WithMany()
                        .HasForeignKey("TheatreModelTheatreId");

                    b.Navigation("MovieModel");

                    b.Navigation("TheatreModel");
                });
#pragma warning restore 612, 618
        }
    }
}
