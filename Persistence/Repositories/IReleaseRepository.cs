using MusicBandsAPI_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Persistence.Repositories
{
    public interface IReleaseRepository
    {
        public ICollection<Release> getReleasesOfABand(int bandID);
        public double getAvgBandReleasesRanking(int bandID);
    }
}
