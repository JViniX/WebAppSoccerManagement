﻿// <auto-generated />
using System;
using Julio_C_301016383.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Julio_C_301016383.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191108031528_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Julio_C_301016383.Models.CartLine", b =>
                {
                    b.Property<int>("CartLineID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MatchID");

                    b.Property<int?>("OrderID");

                    b.Property<int>("Quantity");

                    b.HasKey("CartLineID");

                    b.HasIndex("MatchID");

                    b.HasIndex("OrderID");

                    b.ToTable("CartLine");
                });

            modelBuilder.Entity("Julio_C_301016383.Models.Club", b =>
                {
                    b.Property<int>("ClubID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int?>("MatchID");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ClubID");

                    b.HasIndex("MatchID");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("Julio_C_301016383.Models.Goal", b =>
                {
                    b.Property<int>("GoalID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClubID");

                    b.Property<DateTime?>("GoalTime");

                    b.Property<int>("MatchID");

                    b.Property<int?>("PlayerID");

                    b.HasKey("GoalID");

                    b.HasIndex("MatchID");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("Julio_C_301016383.Models.Match", b =>
                {
                    b.Property<int>("MatchID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Club1Name");

                    b.Property<int>("Club1Score");

                    b.Property<string>("Club2Name");

                    b.Property<int>("Club2Score");

                    b.Property<int>("ClubID1");

                    b.Property<int>("ClubID2");

                    b.Property<bool>("IsFinished");

                    b.Property<DateTime>("MatchDateAndTime");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("Stadium")
                        .IsRequired();

                    b.Property<int>("TournamentID");

                    b.HasKey("MatchID");

                    b.HasIndex("TournamentID");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Julio_C_301016383.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<bool>("GiftWrap");

                    b.Property<string>("Line1")
                        .IsRequired();

                    b.Property<string>("Line2");

                    b.Property<string>("Line3");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Zip");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Julio_C_301016383.Models.Player", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<int>("ClubID");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("PlayerID");

                    b.HasIndex("ClubID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Julio_C_301016383.Models.Tournament", b =>
                {
                    b.Property<int>("TournamentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClubCount");

                    b.Property<DateTime>("From");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("To");

                    b.HasKey("TournamentID");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("Julio_C_301016383.Models.CartLine", b =>
                {
                    b.HasOne("Julio_C_301016383.Models.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchID");

                    b.HasOne("Julio_C_301016383.Models.Order")
                        .WithMany("Lines")
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("Julio_C_301016383.Models.Club", b =>
                {
                    b.HasOne("Julio_C_301016383.Models.Match")
                        .WithMany("ClubList")
                        .HasForeignKey("MatchID");
                });

            modelBuilder.Entity("Julio_C_301016383.Models.Goal", b =>
                {
                    b.HasOne("Julio_C_301016383.Models.Match")
                        .WithMany("Goals")
                        .HasForeignKey("MatchID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Julio_C_301016383.Models.Match", b =>
                {
                    b.HasOne("Julio_C_301016383.Models.Tournament")
                        .WithMany("Matches")
                        .HasForeignKey("TournamentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Julio_C_301016383.Models.Player", b =>
                {
                    b.HasOne("Julio_C_301016383.Models.Club")
                        .WithMany("Players")
                        .HasForeignKey("ClubID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
