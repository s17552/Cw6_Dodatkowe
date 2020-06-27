﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cw6_Dodatkowe.Models
{
    public class Student
    {
        [Key]
        [MaxLength(100)]
        public String IndexNumber { get; set; }
        [MaxLength(100)]
        [Required]
        public String FirstName { get; set; }
        [MaxLength(100)]
        [Required]
        public String LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public int IdEnrollment { get; set; }
        public Enrollment enrollment { get; set; }
    }
}
