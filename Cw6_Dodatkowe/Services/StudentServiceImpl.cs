﻿﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw6_Dodatkowe.Models;

namespace Cw6_Dodatkowe.Services
{
    public class StudentServiceImpl : StudentService
    {
        private readonly StudiesContext studiesContext;

        public StudentServiceImpl(StudiesContext studiesContext)
        {
            this.studiesContext = studiesContext;
        }
        public Student getStudentByIndex(string index)
        {
           
            using (var con = new SqlConnection("Data Source=db-mssql;Initial Catalog=s17552;Integrated Security = True"))
            using (var com = new SqlCommand())
            {
                com.Connection = con;
                con.Open();

                com.CommandText = "SELECT * FROM students WHERE indexnumber = @index";
                com.Parameters.AddWithValue("index", index);
                var dr = com.ExecuteReader();

                if (!dr.Read())
                {
                    dr.Close();
                    return null;
                }

                Student student = new Student();
                student.IndexNumber = dr["IndexNumber"].ToString();
                student.FirstName = dr["FirstName"].ToString();
                student.LastName = dr["LastName"].ToString();

                return student;
            }
        }

        public List<Student> getStudents()
        {
            return studiesContext.students.ToList();
        }
    }
}
