using MusicBandsAPI_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Persistence.Repositories
{
    public interface IBandRepository
    {
        public bool BandExists(Guid bandId);
        public ICollection<Band> getAllBands();
        public Band getBandByID(int bandID);
        public ICollection<String> getAllReleaseTitlesOfABand(int bandID);
    }
}
