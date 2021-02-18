using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Models
{
       public class Membership
       {
           [Key]
           public Guid MembershipId { get; set; }
           [DataType(DataType.Date)]
           [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
           public DateTime StartYear { get; set; }
           [DataType(DataType.Date)]
           [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
           public DateTime EndYear { get; set; }
           public Guid MusicianId { get; set; }
           public Musician Musician { get; set; }
           public Guid BandId { get; set; }
           public Band Band { get; set; }
        // Muscian may or may not have a clear role in the band
           [DisplayFormat(NullDisplayText = "No band role")]
           public Guid ? BandRoleId { get; set; }
           public BandRole BandRole { get; set; }
       } 
}
