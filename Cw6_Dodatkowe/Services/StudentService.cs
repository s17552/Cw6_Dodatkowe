﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw6_Dodatkowe.Models;

namespace Cw6_Dodatkowe.Services
{
    public interface StudentService
    {
        public Student getStudentByIndex(String index);
        public List<Student> getStudents();
    }
}
