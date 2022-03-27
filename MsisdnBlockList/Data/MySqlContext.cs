using Microsoft.EntityFrameworkCore;
using MsisdnBlockList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MsisdnBlockList.Data
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options)
            : base(options)
        {            
            
        }

        public DbSet<MSISDN> msisdn { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<Log> log { get; set; }
    }
}
