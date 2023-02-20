using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DoctorWeb.Models
{
    public class DoctorDBContext:DbContext
    {
        public DbSet<Registration_Form> Registration_Forms { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<BookingOnline> BookingOnlines { get; set; }
        public DbSet<Query> Queries { get; set; }
        public DbSet<Adminlogin> Adminlogins { get; set; }

        public DbSet<Employee> emoloyees { get; set; }
    }
}