using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PracticeEntiry.Models
{
    public class PartMedals
    {
        [Required]
        [Key]
        public int  ID { get; set; }
        [Required]
        public int PartID { get; set; }
        [Required]
        public int SportID { get; set; }
        [Required]
        public int MedalID{ get; set; }
        public Partipicants Partipicants { get; set; }
        public Sports Sport { get; set; }
        public Medals Medals { get; set; }

    }
}
