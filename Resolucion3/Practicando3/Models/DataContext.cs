using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practicando3.Models
{
    public class DataContext : DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Practicando3.Models.Country> Countries { get; set; }
    }
}