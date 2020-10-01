using FMRRoles.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Providers.Entities;

namespace FMRRoles.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>options):base(options)
        {
             
        }
        public DbSet<Role> Role { get; set; }
     
    
    
    }
}
