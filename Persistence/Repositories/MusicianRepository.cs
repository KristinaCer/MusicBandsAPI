using MusicBandsAPI_Project.Models;
using MusicBandsAPI_Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Persistence.Repositories
{
    public class MusicianRepository : IMusicianRepository
    {
        private readonly MusicBandsDbContext _context;

        public MusicianRepository(MusicBandsDbContext context)
        {
            _context = context;
        }

        public bool MusicianExists(Guid musicianID)
        {
            return _context.Musicians.Any(m => m.MusicianId == musicianID);
        }
        public void deleteMusician(Guid musicianID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Musician> getAllMusicians()
        {
            return _context.Musicians.OrderBy(m => m.Name).ToList();
        }

        public ICollection<Musician> getBandMembers(Guid bandID)
        {
            return _context.Musicians.Where(b => b.Membership.Band.BandId == bandID).ToList();
        }

        public Musician getMusician(Guid musicianID)
        {
            return _context.Musicians.Where(m => m.MusicianId == musicianID).FirstOrDefault();
        }

        public string getMusicianWebsite(Guid musicianID)
        {
            return _context.Musicians.Where(m => m.MusicianId == musicianID).Select(m => m.PersonalPage).FirstOrDefault();
        }

        public string updateMusicianWebsite(Guid musicianID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Release> getAllReleasesOfMusician(Guid musicianID){
            return _context.Releases.Where(m => m.Band.Membership.Musician.MusicianId == musicianID).ToList();
        }
    }
}
