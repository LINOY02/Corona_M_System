using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Corona_M_system.Models;

namespace Corona_M_system.Data
{
    public class Corona_M_systemContext : DbContext
    {
        public Corona_M_systemContext (DbContextOptions<Corona_M_systemContext> options)
            : base(options)
        {
        }
        public DbSet<Corona_M_system.Models.Vaccination>? Vaccination { get; set; }
        public DbSet<Corona_M_system.Models.UserInfo>? UserInfo { get; set; }

    }
}
