using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Dtos
{
    public class ReleaseDto
    {
        public Guid ReleaseId { get; set; }
        public string Title { get; set; }
        public double Rating { get; set; }
        public DateTime ReleaseYear { get; set; }
    }
}
