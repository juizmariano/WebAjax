using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCPrueba.Models
{
    public class Student
    {
        public int studentID { get; set; }

        [Required]
        public string studentName { get; set; }
        
        [Required]
        public string studentAddres { get; set; }


    }
}