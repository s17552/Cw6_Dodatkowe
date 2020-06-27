﻿﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cw6_Dodatkowe.Models
{
    public class Enrollment
    {
        [Key]
        public int IdEnrollment { get; set; }
        [Required]
        public int Semester { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public int IdStudy { get; set; }
        public Studies studies { get; set; }
        public List<Student> students { get; set; }
    }
}
