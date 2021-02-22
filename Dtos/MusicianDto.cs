using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Dtos
{
    public class MusicianDto
    {
        public Guid MusicianId { get; set; }
        public string Name { get; set; }
        public string PersonalPage { get; set; }
    }
}
