using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gameflix.Areas.Cyberpunk2077.Models
{
    public class Season1
    {
        public int Season1Id { get; set; }
        [Required]
        [Display(Name = "Episode Number")]
        public int episodeNumber { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Video { get; set; }
    }
}