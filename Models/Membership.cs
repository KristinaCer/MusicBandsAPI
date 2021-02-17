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
           public int MembershipId { get; set; }
           public DateTime StartYear { get; set; }
           public DateTime EndYear { get; set; }
           public int MusicianId { get; set; }
           public Musician Musician { get; set; }
           public int BandId { get; set; }
           public Band Band { get; set; }
           public int BandRoleId { get; set; }
           public BandRole BandRole { get; set; }
       } 
}
