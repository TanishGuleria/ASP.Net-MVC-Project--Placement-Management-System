using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PlacementManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
       
        public string MiddleName { get; set; }
        [Required]

        public string LastName { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string BranchName { get; set; }
        [Required]
        public DateTime GraduationYear { get; set; }
        [Required]
   
        public int Class10thMarks { get; set; }
        [Required]
        public int Class12thMarks { get; set; }
        [Required]

        public float CurrentCgpa { get; set; }
    }

   
}