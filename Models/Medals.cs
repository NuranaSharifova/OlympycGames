using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PracticeEntiry.Models
{
    public class Medals
    {
        [Required]
        [Key]
        public int ID{ get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<PartMedals> PartMedals { get; set; }
    }
}
