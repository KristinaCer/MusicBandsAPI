using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Dtos
{
    public class MembershipDto
    {
        public Guid MembershipId { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime EndYear { get; set; }
    }
}
