﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SeattlePetNanny.Data;
using System;

namespace SeattlePetNanny.Migrations.SeattlePetNanny
{
    [DbContext(typeof(SeattlePetNannyContext))]
    [Migration("20171117024056_invalidColumnNameTroubleshooting")]
    partial class invalidColumnNameTroubleshooting
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SeattlePetNanny.Models.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Neighborhood");

                    b.Property<int>("UserID");

                    b.HasKey("AdminID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("SeattlePetNanny.Models.Dog", b =>
                {
                    b.Property<int>("DogID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Breed");

                    b.Property<string>("Name");

                    b.Property<int>("OwnerId");

                    b.Property<string>("OwnerNotes");

                    b.Property<string>("Temperment");

                    b.Property<string>("WorkerNotes");

                    b.HasKey("DogID");

                    b.HasIndex("OwnerId");

                    b.ToTable("Dog");
                });

            modelBuilder.Entity("SeattlePetNanny.Models.Owner", b =>
                {
                    b.Property<int>("OwnerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Location");

                    b.Property<int>("UserID");

                    b.HasKey("OwnerID");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("SeattlePetNanny.Models.ReportCard", b =>
                {
                    b.Property<int>("ReportCardID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DogID");

                    b.Property<string>("OwnerNotes");

                    b.Property<string>("Report");

                    b.Property<string>("WorkerNotes");

                    b.HasKey("ReportCardID");

                    b.HasIndex("DogID");

                    b.ToTable("ReportCard");
                });

            modelBuilder.Entity("SeattlePetNanny.Models.Worker", b =>
                {
                    b.Property<int>("WorkerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Neighborhood");

                    b.Property<int>("UserID");

                    b.HasKey("WorkerID");

                    b.ToTable("Worker");
                });

            modelBuilder.Entity("SeattlePetNanny.Models.Dog", b =>
                {
                    b.HasOne("SeattlePetNanny.Models.Owner", "Owner")
                        .WithMany("Dogs")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SeattlePetNanny.Models.ReportCard", b =>
                {
                    b.HasOne("SeattlePetNanny.Models.Dog", "Dog")
                        .WithMany("ReportCards")
                        .HasForeignKey("DogID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
