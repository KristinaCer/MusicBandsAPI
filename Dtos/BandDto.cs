using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Dtos
{
    public class BandDto
    {
        public Guid BandId { get; set; }
        public string BandName { get; set; }
        public string BandWebsite { get; set; }
    }
}
