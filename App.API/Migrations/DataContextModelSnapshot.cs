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

            modelBuilder.Entity("App.API.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

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
#pragma warning restore 612, 618
        }
    }
}
