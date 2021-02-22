using MusicBandsAPI_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Persistence.Repositories
{
    public interface IMusicianRepository
    {
        public bool MusicianExists(Guid musicianID);
        public ICollection<Musician> getAllMusicians();
        public Musician getMusician(Guid musicianID);
        public ICollection<Musician> getBandMembers(Guid bandID);
        public void deleteMusician(Guid musicianID);
        public string getMusicianWebsite(Guid musicianID);

        public string updateMusicianWebsite(Guid musicianID);
        public ICollection<Release> getAllReleasesOfMusician(Guid musicianID);
    }
}
