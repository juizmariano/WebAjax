using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPrueba.Models
{
    public class StudentService
    {
       
        public static List<Student> Students { get; set; }

        static StudentService()
        {
            if (Students == null)
            {
                Students = new List<Student>();
            }  
        }
        public static void Add(Student student)
        {
            Students.Add(student);
        }

        public static List<Student>  GetStudents()
        {
            return Students;

        }


    }

    
}