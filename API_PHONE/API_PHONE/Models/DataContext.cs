using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API_PHONE.Models
{
    public class DataContext : DbContext
    {
        public DataContext(): base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<API_PHONE.Models.api_phone> api_phone { get; set; }
    }
}