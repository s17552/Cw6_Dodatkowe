﻿﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cw6_Dodatkowe.Models
{
    public class Studies
    {
        [Key]
        public int IdStudy { get; set; }
        [Required]
        [MaxLength(100)]
        public String Name { get; set; }
        public List<Enrollment> enrollments { get; set; }
    }
}
