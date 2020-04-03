﻿// <auto-generated />
using AnimalApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalApi.Migrations
{
    [DbContext(typeof(AnimalApiContext))]
    partial class AnimalApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Breed = "husky",
                            Name = "Nanuk",
                            Type = "dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Breed = "husky/malamute",
                            Name = "Qiba",
                            Type = "dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Breed = "barn cat",
                            Name = "Meowsley",
                            Type = "cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Breed = "siamese",
                            Name = "Hans Yolo",
                            Type = "cat"
                        });
                });

            modelBuilder.Entity("AnimalApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Token");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Joe",
                            LastName = "Yolo",
                            Password = "password",
                            Username = "joe"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
