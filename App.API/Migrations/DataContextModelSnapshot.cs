﻿// <auto-generated />
using System;
using App.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("App.API.Models.Photo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Userid")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("dateadded")
                        .HasColumnType("TEXT");

                    b.Property<int>("description")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ismain")
                        .HasColumnType("INTEGER");

                    b.Property<string>("url")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("Userid");

                    b.ToTable("photos");
                });

            modelBuilder.Entity("App.API.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("city")
                        .HasColumnType("TEXT");

                    b.Property<string>("country")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dateofbirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("interests")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("lastactive")
                        .HasColumnType("TEXT");

                    b.Property<string>("lookingfor")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("passwordSalt")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("passwordhash")
                        .HasColumnType("BLOB");

                    b.Property<string>("username")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("App.API.Models.Value", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("App.API.Models.Photo", b =>
                {
                    b.HasOne("App.API.Models.User", null)
                        .WithMany("photos")
                        .HasForeignKey("Userid");
                });
#pragma warning restore 612, 618
        }
    }
}
