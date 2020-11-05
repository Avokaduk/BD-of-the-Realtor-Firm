using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BD_of_the_Realtor_Firm.Models;

namespace BD_of_the_Realtor_Firm.Data
{
    public class BD_of_the_Realtor_FirmContext : DbContext
    {
        public BD_of_the_Realtor_FirmContext (DbContextOptions<BD_of_the_Realtor_FirmContext> options)
            : base(options)
        {
        }

        public DbSet<BD_of_the_Realtor_Firm.Models.Staff> Staff { get; set; }

        public DbSet<BD_of_the_Realtor_Firm.Models.Servis> Servis { get; set; }

        public DbSet<BD_of_the_Realtor_Firm.Models.Sellers> Sellers { get; set; }

        public DbSet<BD_of_the_Realtor_Firm.Models.Positions> Positions { get; set; }

        public DbSet<BD_of_the_Realtor_Firm.Models.Contracts> Contracts { get; set; }

        public DbSet<BD_of_the_Realtor_Firm.Models.Buyers> Buyers { get; set; }

        public DbSet<BD_of_the_Realtor_Firm.Models.Apartments> Apartments { get; set; }
    }
}
