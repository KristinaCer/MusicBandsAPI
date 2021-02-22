using Microsoft.EntityFrameworkCore;
using MusicBandsAPI_Project.Models;
using System;

namespace MusicBandsAPI_Project.Services
{
    public class MusicBandsDbContext : DbContext
    {
        public MusicBandsDbContext(DbContextOptions<MusicBandsDbContext> dbContextOptions) : base(dbContextOptions)
        {
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BandRole>().HasData(new BandRole()
            {
                BandRoleId = Guid.Parse("48a9dd48-c698-458c-a72d-c5074d650bd1"),
                RoleName = "Singer"
            },
            new BandRole()
            {
                BandRoleId = Guid.Parse("689754e2-869a-4fe1-8572-73654810f27c"),
                RoleName = "Guitarist"
            },
             new BandRole()
             {
                 BandRoleId = Guid.Parse("5d2cdf51-ef1c-4125-b1d8-1e5e11a27c5e"),
                 RoleName = "Drummer"
             }
            );
            modelBuilder.Entity<Band>().HasData(new Band()
             {
                     BandId = Guid.Parse("b2d87e36-3f69-486c-bd1d-38be2362f274"),
                     BandName = "RHCP",
                     BandWebsite = "https://redhotchilipeppers.com/"
                 },
                 new Band() {
                     BandId = Guid.Parse("32b0b796-17e6-41e5-9e63-209b421b328d"),
                     BandName = "Oasis",
                     BandWebsite = "https://oasis.com/"
                 } );

            modelBuilder.Entity<Musician>().HasData(new Musician()
            {
                MusicianId = Guid.Parse("0a1188a5-97fd-4865-8b60-6a02c6e70115"),
                Name = "Anthony Kiedis", 
                PersonalPage = "https://en.wikipedia.org/wiki/Anthony_Kiedis"
            }, 
            new Musician()
            {
                MusicianId = Guid.Parse("0c79dfac-0fbe-4bd0-9d03-fc08d908917b"),
                Name = "Flea",
                PersonalPage = "https://en.wikipedia.org/wiki/Flea_(musician)"
            },
            new Musician()
            {
                MusicianId = Guid.Parse("975589fc-066f-47ae-b3dd-100d6b422976"),
                Name = "Chad Smith",
                PersonalPage = "https://en.wikipedia.org/wiki/Chad_Smith"
            },
            new Musician()
            {
                MusicianId = Guid.Parse("f0f7b8ee-b9b6-4790-8408-d6a374afb06a"),
                Name = "John Frusciante",
                PersonalPage = "https://en.wikipedia.org/wiki/John_Frusciante"
            }
            );

            modelBuilder.Entity<Membership>().HasData(new Membership()
            {
                MembershipId = Guid.Parse("8976d0a7-a23e-450c-b9f8-47873eba701e"),
                StartYear = new DateTime(2000, 01, 01),
                EndYear = DateTime.MaxValue,
                MusicianId = Guid.Parse("0a1188a5-97fd-4865-8b60-6a02c6e70115"),
                BandId = Guid.Parse("b2d87e36-3f69-486c-bd1d-38be2362f274"),
                BandRoleId = Guid.Parse("689754e2-869a-4fe1-8572-73654810f27c")
            }) ;
            
            modelBuilder.Entity<ReleaseType>().HasData(new ReleaseType()
            {
            ReleaseTypeId = Guid.Parse("94f59e91-049b-4706-86db-e601c4264a2b"),
            Title = "Album"
            },
            new ReleaseType()
            {
                ReleaseTypeId = Guid.Parse("eda1e6f8-edbd-4c49-8438-dba8da3e2859"),
                Title = "Single"
            }
            );     
            modelBuilder.Entity<Release>().HasData(new Release()
            {
                ReleaseId = Guid.Parse("8c69defb-8efb-46da-ac92-50c9bd527bc3"),
                Title = "Californication", 
                Rating = 10.0,
                BandId = Guid.Parse("b2d87e36-3f69-486c-bd1d-38be2362f274"),
                ReleaseTypeId = Guid.Parse("94f59e91-049b-4706-86db-e601c4264a2b")
            });

            modelBuilder.Entity<Song>(entity =>
            {
                entity.HasOne(d => d.Release)
                    .WithMany(p => p.Songs)
                    .HasForeignKey("ReleaseId");
            });

            modelBuilder.Entity<Song>().HasData(new Song()
            {
                SongId = Guid.Parse("a15cddc8-8788-4c37-ad52-b59e12a54607"),
                Title = "Scar Tissue",
                AwardReceived = true,
                ReleaseId = Guid.Parse("8c69defb-8efb-46da-ac92-50c9bd527bc3")
            },
            new Song()
            {
                SongId = Guid.Parse("8b90681c-c647-474f-a56f-8fef8a88ec02"),
                Title = "Californication",
                AwardReceived = true,
                ReleaseId = Guid.Parse("8c69defb-8efb-46da-ac92-50c9bd527bc3")
            }
                );

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Band> Bands { get; set; }
        public virtual DbSet<Release> Releases { get; set; }
        public virtual DbSet<BandRole> BandRoles { get; set; }
        public virtual DbSet<Membership> Memberships { get; set; }
        public virtual DbSet<Musician> Musicians { get; set; }
        public virtual DbSet<ReleaseType> ReleaseTypes { get; set; }
        public virtual DbSet<Song> Songs { get; set; } 
    }
} 
