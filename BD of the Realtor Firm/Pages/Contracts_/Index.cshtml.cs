﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_of_the_Realtor_Firm.Data;
using BD_of_the_Realtor_Firm.Models;

namespace BD_of_the_Realtor_Firm.Pages.Contracts_
{
    public class IndexModel : PageModel
    {
        private readonly BD_of_the_Realtor_Firm.Data.BD_of_the_Realtor_FirmContext _context;

        public IndexModel(BD_of_the_Realtor_Firm.Data.BD_of_the_Realtor_FirmContext context)
        {
            _context = context;
        }

        public IList<Contracts> Contracts { get;set; }
        public IList<Buyers> Buyers { get; set; }
        public IList<Sellers> Sellers { get; set; }
        public IList<Apartments> Apartments { get; set; }
        public IList<Staff> Staff { get; set; }

        public async Task OnGetAsync()
        {
            Contracts = await _context.Contracts.ToListAsync();
            Buyers = await _context.Buyers.ToListAsync();
            Sellers = await _context.Sellers.ToListAsync();
            Apartments = await _context.Apartments.ToListAsync();
            Staff = await _context.Staff.ToListAsync();

        }
    }
}
