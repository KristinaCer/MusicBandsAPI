using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Models
{
     public class Song
     {
         [Key]
         public int SongId { get; set; }
         [Required]
         [MaxLength(300, ErrorMessage = "Song title cannot be longer than 300 characters.")]
         public string Title { get; set; }
         public bool AwardReceived { get; set; }
         public int ReleaseId { get; set; }
         public virtual Release Release { get; set; }
     } 
}
