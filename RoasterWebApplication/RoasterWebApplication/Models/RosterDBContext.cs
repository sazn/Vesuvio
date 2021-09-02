using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoasterWebApplication.Models
{
    public class RosterDBContext : DbContext
    {
        public RosterDBContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Member> Members {get;set;}
    }
}
