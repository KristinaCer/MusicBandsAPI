﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicBandsAPI_Project.Services;

namespace MusicBandsAPI_Project.Migrations
{
    [DbContext(typeof(MusicBandsDbContext))]
    partial class MusicBandsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            BandId = new Guid("b2d87e36-3f69-486c-bd1d-38be2362f274"),
                            BandName = "RHCP",
                            BandWebsite = "https://redhotchilipeppers.com/"
                        },
                        new
                        {
                            BandId = new Guid("32b0b796-17e6-41e5-9e63-209b421b328d"),
                            BandName = "Oasis",
                            BandWebsite = "https://oasis.com/"
                        });
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

                    b.HasData(
                        new
                        {
                            BandRoleId = new Guid("48a9dd48-c698-458c-a72d-c5074d650bd1"),
                            RoleName = "Singer"
                        },
                        new
                        {
                            BandRoleId = new Guid("689754e2-869a-4fe1-8572-73654810f27c"),
                            RoleName = "Guitarist"
                        },
                        new
                        {
                            BandRoleId = new Guid("5d2cdf51-ef1c-4125-b1d8-1e5e11a27c5e"),
                            RoleName = "Drummer"
                        });
                });

            modelBuilder.Entity("MusicBandsAPI_Project.Models.Membership", b =>
                {
                    b.Property<Guid>("MembershipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BandRoleId")
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
                        .IsUnique()
                        .HasFilter("[BandRoleId] IS NOT NULL");

                    b.HasIndex("MusicianId")
                        .IsUnique();

                    b.ToTable("Memberships");

                    b.HasData(
                        new
                        {
                            MembershipId = new Guid("8976d0a7-a23e-450c-b9f8-47873eba701e"),
                            BandId = new Guid("b2d87e36-3f69-486c-bd1d-38be2362f274"),
                            BandRoleId = new Guid("689754e2-869a-4fe1-8572-73654810f27c"),
                            EndYear = new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999),
                            MusicianId = new Guid("0a1188a5-97fd-4865-8b60-6a02c6e70115"),
                            StartYear = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
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

                    b.HasData(
                        new
                        {
                            MusicianId = new Guid("0a1188a5-97fd-4865-8b60-6a02c6e70115"),
                            Name = "Anthony Kiedis",
                            PersonalPage = "https://en.wikipedia.org/wiki/Anthony_Kiedis"
                        },
                        new
                        {
                            MusicianId = new Guid("0c79dfac-0fbe-4bd0-9d03-fc08d908917b"),
                            Name = "Flea",
                            PersonalPage = "https://en.wikipedia.org/wiki/Flea_(musician)"
                        },
                        new
                        {
                            MusicianId = new Guid("975589fc-066f-47ae-b3dd-100d6b422976"),
                            Name = "Chad Smith",
                            PersonalPage = "https://en.wikipedia.org/wiki/Chad_Smith"
                        },
                        new
                        {
                            MusicianId = new Guid("f0f7b8ee-b9b6-4790-8408-d6a374afb06a"),
                            Name = "John Frusciante",
                            PersonalPage = "https://en.wikipedia.org/wiki/John_Frusciante"
                        });
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

                    b.HasData(
                        new
                        {
                            ReleaseId = new Guid("8c69defb-8efb-46da-ac92-50c9bd527bc3"),
                            BandId = new Guid("b2d87e36-3f69-486c-bd1d-38be2362f274"),
                            Rating = 10.0,
                            ReleaseTypeId = new Guid("94f59e91-049b-4706-86db-e601c4264a2b"),
                            ReleaseYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Californication"
                        });
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

                    b.HasData(
                        new
                        {
                            ReleaseTypeId = new Guid("94f59e91-049b-4706-86db-e601c4264a2b"),
                            Title = "Album"
                        },
                        new
                        {
                            ReleaseTypeId = new Guid("eda1e6f8-edbd-4c49-8438-dba8da3e2859"),
                            Title = "Single"
                        });
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

                    b.HasData(
                        new
                        {
                            SongId = new Guid("a15cddc8-8788-4c37-ad52-b59e12a54607"),
                            AwardReceived = true,
                            ReleaseId = new Guid("8c69defb-8efb-46da-ac92-50c9bd527bc3"),
                            Title = "Scar Tissue"
                        },
                        new
                        {
                            SongId = new Guid("8b90681c-c647-474f-a56f-8fef8a88ec02"),
                            AwardReceived = true,
                            ReleaseId = new Guid("8c69defb-8efb-46da-ac92-50c9bd527bc3"),
                            Title = "Californication"
                        });
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
                        .HasForeignKey("MusicBandsAPI_Project.Models.Membership", "BandRoleId");

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
