using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCDataInsertingToDB.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Emplyee> Employees { get; set; }
    }
}