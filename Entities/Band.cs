using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Models
{
    public class Band
    {
        [Key]
        public Guid BandId { get; set; }
        [Required]
        [MaxLength(300, ErrorMessage = "Band name cannot be longer than 300 characters.")]
        public string BandName { get; set; }
        [Url]
        public string BandWebsite { get; set; }
        public Membership Membership { get; set; }
        public Release Release { get; set; }
    }
}
