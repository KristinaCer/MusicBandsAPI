using MusicBandsAPI_Project.Models;
using MusicBandsAPI_Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Persistence.Repositories
{
    public class BandRepository : IBandRepository
    {
        private readonly MusicBandsDbContext _dbContext;

        public BandRepository(MusicBandsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool BandExists(Guid bandId)
        {
            return _dbContext.Bands.Any(b => b.BandId == bandId);
        }

        public ICollection<Band> getAllBands()
        {
            throw new NotImplementedException();
        }

        public Band getBandByID(int bandID)
        {
            throw new NotImplementedException();
        }

        public Band getBandByName(string bandName)
        {
            throw new NotImplementedException();
        }
        public ICollection<String> getAllReleaseTitlesOfABand(int bandID)
        {
            throw new NotImplementedException();

        }

    }
}
