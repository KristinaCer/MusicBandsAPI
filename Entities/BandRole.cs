using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Models
{
   public class BandRole
   {
        [Key]
        public Guid BandRoleId { get; set; }
        [Required]
        [MaxLength(300, ErrorMessage = "Role name cannot be longer than 300 characters.")]
        public string RoleName { get; set; }
        public Membership Membership { get; set; }
    } 
}
