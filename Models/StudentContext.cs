using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PlacementManagement.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext():base("name=StudentDb")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Login> logins { get; set; }
        public DbSet<Companies> Companies { get; set; }
    }
}