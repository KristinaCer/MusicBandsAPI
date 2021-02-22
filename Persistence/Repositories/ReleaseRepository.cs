using MusicBandsAPI_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Persistence.Repositories
{
    public class ReleaseRepository : IReleaseRepository
    {
        public double getAvgBandReleasesRanking(int bandID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Release> getReleasesOfABand(int bandID)
        {
            throw new NotImplementedException();
        }
    }
}
