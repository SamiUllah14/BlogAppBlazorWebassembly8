﻿// <auto-generated />
using System;
using BlogApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogApp.Server.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240412103322_userss")]
    partial class userss
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogApp.Server.Models.Authentication.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlogApp.Server.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReadMoreUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description 1",
                            ImageUrl = "/Images/Anime.JPG",
                            ReadMoreUrl = "",
                            Title = "Title 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description 2",
                            ImageUrl = "/path/to/image2.jpg",
                            ReadMoreUrl = "",
                            Title = "Title 2"
                        });
                });

            modelBuilder.Entity("BlogApp.Server.Models.CardDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<string>("MoreDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.ToTable("CardDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CardId = 1,
                            MoreDescription = "The whole detail is here more description matedddddcdcdcdc"
                        });
                });

            modelBuilder.Entity("BlogApp.Server.Models.CardDetail", b =>
                {
                    b.HasOne("BlogApp.Server.Models.Card", "card")
                        .WithOne("cardDetail")
                        .HasForeignKey("BlogApp.Server.Models.CardDetail", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("card");
                });

            modelBuilder.Entity("BlogApp.Server.Models.Card", b =>
                {
                    b.Navigation("cardDetail")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
