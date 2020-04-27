using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PlacementManagement.Models
{
    public class Companies
    {   
        
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public long SalaryPackage { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int CutoffPercentage { get; set; }
        [Required]
        public DateTime DateOfDrive { get; set; }

    }
}