﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlympicFlags.Models;

namespace OlympicFlags.Migrations
{
    [DbContext(typeof(CountryContext))]
    [Migration("20210629025854_ne")]
    partial class ne
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OlympicFlags.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "i",
                            Name = "Indoor"
                        },
                        new
                        {
                            CategoryId = "o",
                            Name = "Outdoor"
                        });
                });

            modelBuilder.Entity("OlympicFlags.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GameId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LogoImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SportId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CountryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("GameId");

                    b.HasIndex("SportId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CategoryId = "o",
                            GameId = "p",
                            LogoImage = "Austria.png",
                            Name = "Austria",
                            SportId = "cs"
                        },
                        new
                        {
                            CountryId = 2,
                            CategoryId = "o",
                            GameId = "s",
                            LogoImage = "Brazil.png",
                            Name = "Brazil",
                            SportId = "r"
                        },
                        new
                        {
                            CountryId = 3,
                            CategoryId = "i",
                            GameId = "w",
                            LogoImage = "Canada.png",
                            Name = "Canada",
                            SportId = "c"
                        },
                        new
                        {
                            CountryId = 4,
                            CategoryId = "i",
                            GameId = "s",
                            LogoImage = "China.png",
                            Name = "China",
                            SportId = "d"
                        },
                        new
                        {
                            CountryId = 5,
                            CategoryId = "i",
                            GameId = "y",
                            LogoImage = "Cyprus.png",
                            Name = "Cyrpus",
                            SportId = "bd"
                        },
                        new
                        {
                            CountryId = 6,
                            CategoryId = "o",
                            GameId = "y",
                            LogoImage = "Finland.png",
                            Name = "Finland",
                            SportId = "s"
                        },
                        new
                        {
                            CountryId = 7,
                            CategoryId = "i",
                            GameId = "y",
                            LogoImage = "France.png",
                            Name = "France",
                            SportId = "bd"
                        },
                        new
                        {
                            CountryId = 8,
                            CategoryId = "i",
                            GameId = "s",
                            LogoImage = "Germany.png",
                            Name = "Germany",
                            SportId = "d"
                        },
                        new
                        {
                            CountryId = 9,
                            CategoryId = "i",
                            GameId = "w",
                            LogoImage = "Great Britain.png",
                            Name = "Great Britian",
                            SportId = "c"
                        },
                        new
                        {
                            CountryId = 10,
                            CategoryId = "o",
                            GameId = "w",
                            LogoImage = "Italy.png",
                            Name = "Italy",
                            SportId = "b"
                        },
                        new
                        {
                            CountryId = 11,
                            CategoryId = "o",
                            GameId = "w",
                            LogoImage = "Jamaica.png",
                            Name = "Jamaica",
                            SportId = "b"
                        },
                        new
                        {
                            CountryId = 12,
                            CategoryId = "o",
                            GameId = "w",
                            LogoImage = "Japan.png",
                            Name = "Japan",
                            SportId = "b"
                        },
                        new
                        {
                            CountryId = 13,
                            CategoryId = "i",
                            GameId = "s",
                            LogoImage = "Mexico.png",
                            Name = "Mexico",
                            SportId = "d"
                        },
                        new
                        {
                            CountryId = 14,
                            CategoryId = "o",
                            GameId = "s",
                            LogoImage = "Netherlands.png",
                            Name = "Netherlands",
                            SportId = "r"
                        },
                        new
                        {
                            CountryId = 15,
                            CategoryId = "o",
                            GameId = "p",
                            LogoImage = "Pakistan.png",
                            Name = "Pakistan",
                            SportId = "cs"
                        },
                        new
                        {
                            CountryId = 16,
                            CategoryId = "o",
                            GameId = "y",
                            LogoImage = "Portugal.png",
                            Name = "Portugal",
                            SportId = "s"
                        },
                        new
                        {
                            CountryId = 17,
                            CategoryId = "i",
                            GameId = "y",
                            LogoImage = "Russia.png",
                            Name = "Russia",
                            SportId = "bd"
                        },
                        new
                        {
                            CountryId = 18,
                            CategoryId = "o",
                            GameId = "y",
                            LogoImage = "Slovakia.png",
                            Name = "Slovakia",
                            SportId = "s"
                        },
                        new
                        {
                            CountryId = 19,
                            CategoryId = "i",
                            GameId = "w",
                            LogoImage = "Sweden.png",
                            Name = "Sweden",
                            SportId = "c"
                        },
                        new
                        {
                            CountryId = 20,
                            CategoryId = "i",
                            GameId = "p",
                            LogoImage = "Thailand.png",
                            Name = "Thailand",
                            SportId = "a"
                        },
                        new
                        {
                            CountryId = 21,
                            CategoryId = "i",
                            GameId = "p",
                            LogoImage = "Ukraine.png",
                            Name = "Ukraine",
                            SportId = "a"
                        },
                        new
                        {
                            CountryId = 22,
                            CategoryId = "i",
                            GameId = "p",
                            LogoImage = "Uruguay.png",
                            Name = "Uruguay",
                            SportId = "a"
                        },
                        new
                        {
                            CountryId = 23,
                            CategoryId = "o",
                            GameId = "s",
                            LogoImage = "USA.png",
                            Name = "USA",
                            SportId = "r"
                        },
                        new
                        {
                            CountryId = 24,
                            CategoryId = "o",
                            GameId = "p",
                            LogoImage = "Zimbabwe.png",
                            Name = "Zimbabwe",
                            SportId = "cs"
                        });
                });

            modelBuilder.Entity("OlympicFlags.Models.Game", b =>
                {
                    b.Property<string>("GameId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = "s",
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            GameId = "w",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            GameId = "p",
                            Name = "Paralympics"
                        },
                        new
                        {
                            GameId = "y",
                            Name = "Youth Olympics"
                        });
                });

            modelBuilder.Entity("OlympicFlags.Models.Sport", b =>
                {
                    b.Property<string>("SportId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SportId");

                    b.ToTable("Sports");

                    b.HasData(
                        new
                        {
                            SportId = "a",
                            Name = "Archery"
                        },
                        new
                        {
                            SportId = "b",
                            Name = "Bobsleigh"
                        },
                        new
                        {
                            SportId = "bd",
                            Name = "Breakdancing"
                        },
                        new
                        {
                            SportId = "cs",
                            Name = "Canoe Sprint"
                        },
                        new
                        {
                            SportId = "c",
                            Name = "Curling"
                        },
                        new
                        {
                            SportId = "d",
                            Name = "Diving"
                        },
                        new
                        {
                            SportId = "r",
                            Name = "Road Cycling"
                        },
                        new
                        {
                            SportId = "s",
                            Name = "Skateboarding"
                        });
                });

            modelBuilder.Entity("OlympicFlags.Models.Country", b =>
                {
                    b.HasOne("OlympicFlags.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("OlympicFlags.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.HasOne("OlympicFlags.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("SportId");

                    b.Navigation("Category");

                    b.Navigation("Game");

                    b.Navigation("Sport");
                });
#pragma warning restore 612, 618
        }
    }
}
