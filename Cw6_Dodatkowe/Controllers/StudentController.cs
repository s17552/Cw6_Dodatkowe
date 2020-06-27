﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cw6_Dodatkowe.Services;

namespace Cw6_Dodatkowe.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentService dbservice;

        public StudentController(StudentService dbservice)
        {
            this.dbservice = dbservice;
        }

        [HttpGet]
        public IActionResult getStudents()
        {
            return Ok(dbservice.getStudents());
        }

    }
}
