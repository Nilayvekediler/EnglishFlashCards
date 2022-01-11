﻿// <auto-generated />
using EnglishFlashCardsWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EnglishFlashCardsWeb.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211228120936_turanilco")]
    partial class turanilco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EnglishFlashCardsWeb.Models.CardSet", b =>
                {
                    b.Property<int>("setID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cardSetUserID")
                        .HasColumnType("int");

                    b.Property<int>("folderID")
                        .HasColumnType("int");

                    b.Property<string>("setName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("setID");

                    b.ToTable("CardSets");
                });

            modelBuilder.Entity("EnglishFlashCardsWeb.Models.FlashCard", b =>
                {
                    b.Property<int>("cardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardsetID")
                        .HasColumnType("int");

                    b.Property<int>("cardUserID")
                        .HasColumnType("int");

                    b.Property<string>("meaning")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senaryo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("word")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wordType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cardID");

                    b.ToTable("FlashCards");
                });

            modelBuilder.Entity("EnglishFlashCardsWeb.Models.Folder", b =>
                {
                    b.Property<int>("folderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("folderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userID")
                        .HasColumnType("int");

                    b.HasKey("folderID");

                    b.ToTable("Folders");
                });

            modelBuilder.Entity("EnglishFlashCardsWeb.Models.SetFolderMatch", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("folderID")
                        .HasColumnType("int");

                    b.Property<int>("setID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("SetFolderMatches");
                });

            modelBuilder.Entity("EnglishFlashCardsWeb.Models.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}