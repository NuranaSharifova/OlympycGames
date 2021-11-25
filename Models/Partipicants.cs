using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PracticeEntiry.Models
{
   public class Partipicants
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public int CountryID { get; set; }
        public Countries Country{ get; set; }

    }
}
