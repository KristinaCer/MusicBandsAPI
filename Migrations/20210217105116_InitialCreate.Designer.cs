﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicBandsAPI_Project.Services;

namespace MusicBandsAPI_Project.Migrations
{
    [DbContext(typeof(MusicBandsDbContext))]
    [Migration("20210217105116_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("MusicBandsAPI_Project.Models.Band", b =>
                {
                    b.Property<Guid>("BandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BandName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("BandWebsite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BandId");

                    b.ToTable("Bands");
                });

            modelBuilder.Entity("MusicBandsAPI_Project.Models.BandRole", b =>
                {
                    b.Property<Guid>("BandRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("BandRoleId");

                    b.ToTable("BandRoles");
                });

            modelBuilder.Entity("MusicBandsAPI_Project.Models.Membership", b =>
                {
                    b.Property<Guid>("MembershipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BandRoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndYear")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MusicianId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartYear")
                        .HasColumnType("datetime2");

                    b.HasKey("MembershipId");

                    b.HasIndex("BandId")
                        .IsUnique();

                    b.HasIndex("BandRoleId")
                        .IsUnique();

                    b.HasIndex("MusicianId")
                        .IsUnique();

                    b.ToTable("Memberships");
                });

            modelBuilder.Entity("MusicBandsAPI_Project.Models.Musician", b =>
                {
                    b.Property<Guid>("MusicianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("PersonalPage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MusicianId");

                    b.ToTable("Musicians");
                });

            modelBuilder.Entity("MusicBandsAPI_Project.Models.Release", b =>
                {
                    b.Property<Guid>("ReleaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<Guid>("ReleaseTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ReleaseYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("ReleaseId");

                    b.HasIndex("BandId")
                        .IsUnique();

                    b.HasIndex("ReleaseTypeId")
                        .IsUnique();

                    b.ToTable("Releases");
                });

            modelBuilder.Entity("MusicBandsAPI_Project.Models.ReleaseType", b =>
                {
                    b.Property<Guid>("ReleaseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("ReleaseTypeId");

                    b.ToTable("ReleaseTypes");
                });

            modelBuilder.Entity("MusicBandsAPI_Project.Models.Song", b =>
                {
                    b.Property<Guid>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AwardReceived")
                        .HasColumnType("bit");

                    b.Property<Guid>("ReleaseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("SongId");

                    b.HasIndex("ReleaseId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("MusicBandsAPI_Project.Models.Membership", b =>
                {
                    b.HasOne("MusicBandsAPI_Project.Models.Band", "Band")
                        .WithOne("Membership")
                        .HasForeignKey("MusicBandsAPI_Project.Models.Membership", "BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicBandsAPI_Project.Models.BandRole", "BandRole")
                        .WithOne("Membership")
                        .HasForeignKey("MusicBandsAPI_Project.Models.Membership", "BandRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicBandsAPI_Project.Models.Musician", "Musician")
                        .WithOne("Membership")
                        .HasForeignKey("MusicBandsAPI_Project.Models.Membership", "MusicianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Band");

                    b.Navigation("BandRole");

                    b.Navigation("Musician");
                });

            modelBuilder.Entity("MusicBandsAPI_Project.Models.Release", b =>
                {
                    b.HasOne("MusicBandsAPI_Project.Models.Band", "Band")
                        .WithOne("Release")
                        .HasForeignKey("MusicBandsAPI_Project.Models.Release", "BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicBandsAPI_Project.Models.ReleaseType", "ReleaseType")
                        .WithOne("Release")
                        .HasForeignKey("MusicBandsAPI_Project.Models.Release", "ReleaseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Band");

                    b.Navigation("ReleaseType");
                });

            modelBuilder.Entity("MusicBandsAPI_Project.Models.Song", b =>
                {
                    b.HasOne("MusicBandsAPI_Project.Models.Release", "Release")
                        .WithMany("Songs")
                        .HasForeignKey("ReleaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Release");
                });

            modelBuilder.Entity("MusicBandsAPI_Project.Models.Band", b =>
                {
                    b.Navigation("Membership");

                    b.Navigation("Release");
                });

            modelBuilder.Entity("MusicBandsAPI_Project.Models.BandRole", b =>
                {
                    b.Navigation("Membership");
                });

            modelBuilder.Entity("MusicBandsAPI_Project.Models.Musician", b =>
                {
                    b.Navigation("Membership");
                });

            modelBuilder.Entity("MusicBandsAPI_Project.Models.Release", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("MusicBandsAPI_Project.Models.ReleaseType", b =>
                {
                    b.Navigation("Release");
                });
#pragma warning restore 612, 618
        }
    }
}
