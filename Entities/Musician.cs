using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Models
{
      public class Musician
    {
         [Key]
         public Guid MusicianId { get; set; }
         [Required]
         [MaxLength(300, ErrorMessage = "Musician name cannot be longer than 300 characters.")]
         public string Name { get; set; }
         [Url]
         public string PersonalPage { get; set; }
         public Membership Membership { get; set; }
     } 
}
