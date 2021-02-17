using Microsoft.EntityFrameworkCore;
using MusicBandsAPI_Project.Models;

namespace MusicBandsAPI_Project.Services
{
    public class MusicBandsDbContext : DbContext
    {
        public MusicBandsDbContext(DbContextOptions<MusicBandsDbContext> dbContextOptions) : base(dbContextOptions)
        {
            Database.Migrate();
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
