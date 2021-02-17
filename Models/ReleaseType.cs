using MusicBandsAPI_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Models

{
       public class ReleaseType
     {
          [Key]
          public int ReleaseTypeId { get; set; }
          [Required]
          [MaxLength(300, ErrorMessage = "Role name cannot be longer than 300 characters.")]
          public string Title { get; set; }
          public Release Release { get; set; }
      } 
}
