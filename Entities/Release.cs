﻿using MusicBandsAPI_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Models
{
    public class Release
    {
        [Key]
        public Guid ReleaseId { get; set; }
        [Required]
        [MaxLength(300, ErrorMessage = "Role name cannot be longer than 300 characters.")]
        public string Title { get; set; }
        [Range(1, 10)]
        public double Rating { get; set; }
        public DateTime ReleaseYear { get; set; }
        public Guid BandId { get; set; }
        public Band Band { get; set; }
        public Guid ReleaseTypeId { get; set; }
        public ReleaseType ReleaseType { get; set; }
        public virtual ICollection <Song> Songs { get; set; }
    } 
}
