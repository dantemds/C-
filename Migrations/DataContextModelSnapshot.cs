﻿// <auto-generated />
using System;
using InfoJobs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InfoJobs.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("InfoJobs.Models.CandidateExperiences", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CandidatesId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(4000)
                        .IsUnicode(false);

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdCandidates")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("TEXT");

                    b.Property<float>("Salary")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CandidatesId");

                    b.ToTable("CandidateExperiences");
                });

            modelBuilder.Entity("InfoJobs.Models.Candidates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(250)
                        .IsUnicode(true);

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("InfoJobs.Models.CandidateExperiences", b =>
                {
                    b.HasOne("InfoJobs.Models.Candidates", "Candidates")
                        .WithMany("Experiences")
                        .HasForeignKey("CandidatesId");
                });
#pragma warning restore 612, 618
        }
    }
}