using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PracticeEntiry.Models
{
    public class Countries
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        public string Name{ get; set; }
        public ICollection <Partipicants> Partipicants { get; set; }

    }
}
